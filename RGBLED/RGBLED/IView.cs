﻿using System;
using System.Windows.Forms;

namespace RGBLED
{
    public interface IView
    {
        event EventHandler SetColorHSV;
        event EventHandler PortChanged;
        event EventHandler ThrottleChanged;

        VScrollBar ScrollBar { get; set; }
        Label ColorLabel { get; set; }
        Panel ColorPanel { get; set; }
        TextBox Port { get; set; }
        NumericUpDown Throttle { get; set; }
        void Show();
    }
}