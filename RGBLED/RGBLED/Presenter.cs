using System;
using System.Windows.Forms;

namespace RGBLED
{
    public class Presenter
    {
        readonly IView _View;
        readonly IModel _Model;

        public Presenter(IView view, IModel model)
        {
            _View = view;
            _Model = model;
            _View.Show();
            _View.ScrollBar.Focus();
            _View.Port.Text = _Model.PortString;
            _View.Throttle.Value = (decimal)_Model.Throttle;
            Connect();
            _View.SetColorHSV += SetColorHSV;
            _View.PortChanged += _View_PortChanged;
            _View.PortConnectRequested += _View_PortConnectRequested;
            _View.ThrottleChanged += _View_ThrottleChanged;
        }

        private void Connect()
        {
            if (!_Model.Initialize()) _View.Port.BackColor = System.Drawing.Color.LightCoral;
        }

        private void SetColorHSV(object sender, EventArgs e)
        {
            _Model.HSV = ((VScrollBar)sender).Value;
            _Model.SetColor();
            _View.ColorLabel.Text = _Model.HSV.ToString() + '°';
            _View.ColorPanel.BackColor = System.Drawing.Color.FromArgb(_Model.R, _Model.G, _Model.B);
        }

        private void _View_PortChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string portBuffer = textBox.Text;
            string[] parts = portBuffer.Split('.');
            bool validPort = parts.Length == 4;
            if (validPort)
                foreach (string part in parts)
                    validPort = int.TryParse(part, out int _);
            if (validPort)
            {
                _Model.PortString = portBuffer;
                _View.Port.BackColor = System.Drawing.Color.White;
            }
            else
                _View.Port.BackColor = System.Drawing.Color.Gold;
        }

        private void _View_PortConnectRequested(object sender, EventArgs e)
        {
            _View.Port.Text = _Model.PortString;
            Connect();
        }

        private void _View_ThrottleChanged(object sender, EventArgs e)
        {
            _Model.Throttle = (double)_View.Throttle.Value;
            _Model.SetColor();
        } 
    }
}
