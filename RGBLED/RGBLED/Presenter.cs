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
            _Model.Initialize();
            _View.SetColorHSV += SetColorHSV;
            _View.PortChanged += _View_PortChanged;
            _View.ThrottleChanged += _View_ThrottleChanged;
        }

        private void SetColorHSV(object sender, EventArgs e)
        {
            _Model.HSV = ((VScrollBar)sender).Value;
            _Model.SetColor();
            _View.ColorLabel.Text = _Model.HSV.ToString();
            _View.ColorPanel.BackColor = System.Drawing.Color.FromArgb(_Model.R, _Model.G, _Model.B);
        }

        private void _View_PortChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _View_ThrottleChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
