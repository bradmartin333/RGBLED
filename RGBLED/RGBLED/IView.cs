using System;
using System.Windows.Forms;

namespace RGBLED
{
    public interface IView
    {
        event EventHandler SetColorHSV;
        Label ColorLabel { get; set; }
        Panel ColorPanel { get; set; }
        double RedThrottle { get; set; }
        string PortString { get; set; }
        void Show();
    }
}