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
            _View.SetColorHSV += SetColorHSV;
            _View.Show();
        }

        private void SetColorHSV(object sender, EventArgs e)
        {
            _Model.HSV = ((VScrollBar)sender).Value;
            _Model.SetColor();
            _View.ColorLabel.Text = _Model.HSV.ToString();
            _View.ColorPanel.BackColor = System.Drawing.Color.FromArgb(_Model.R, _Model.G, _Model.B);
        }
    }
}
