using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RGBLED
{
    public partial class FormMain : Form, IFormMain
    {
        public event EventHandler SetColor;

        public FormMain()
        {
            InitializeComponent();

            Rthrottle = 43.75;
            HSVdegrees = true;
            propertyGrid.BrowsableAttributes = new AttributeCollection(new CategoryAttribute("User Parameters"));
            propertyGrid.SelectedObject = this;

            vScrollBarHSV.ValueChanged += delegate { SetColor?.Invoke(this, EventArgs.Empty); };
            vScrollBarR.ValueChanged += delegate { SetColor?.Invoke(this, EventArgs.Empty); };
            vScrollBarG.ValueChanged += delegate { SetColor?.Invoke(this, EventArgs.Empty); };
            vScrollBarB.ValueChanged += delegate { SetColor?.Invoke(this, EventArgs.Empty); };
        }

        public string HSLval { set => labelHSV.Text = $"{value}{(HSVdegrees ? "°" : "")}"; }

        public string Rval { set => labelR.Text = $"{value}"; }

        public string Gval { set => labelG.Text = $"{value}"; }

        public string Bval { set => labelB.Text = $"{value}"; }

        [Category("User Parameters")]
        [DisplayName("Red%")]
        [Description("Percentage by which to throttle the max current delivered to the Red channel")]
        public double Rthrottle { get; set; }

        [Category("User Parameters")]
        [DisplayName("HSV")]
        [Description("True: display HSV degrees (0-360), False: display level (0-100)")]
        public bool HSVdegrees { get; set; }

    }
}
