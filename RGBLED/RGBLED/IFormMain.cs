using System;
using System.ComponentModel;

namespace RGBLED
{
    public interface IFormMain
    {
        event EventHandler SetColor;
        string HSLval { set; }
        string Rval { set; }
        string Gval { set; }
        string Bval { set; }
        double Rthrottle { get; set; }
        bool HSVdegrees { get; set; }
    }
}