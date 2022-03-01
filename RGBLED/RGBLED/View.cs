using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RGBLED
{
    public partial class View : Form, IView
    {
        [Category("User Parameters")]
        [DisplayName("Red%")]
        [Description("Percentage by which to throttle the max current delivered to the Red channel")]
        public double RedThrottle { get; set; }

        [Category("User Parameters")]
        [DisplayName("Port")]
        [Description("IP address of Brainboxes controller")]
        public string PortString { get; set; } = "191.168.1.11";
        public Label ColorLabel { get; set; }
        public Panel ColorPanel { get; set; }

        public event EventHandler SetColorHSV;

        public View()
        {
            InitializeComponent();
            new Presenter(this, new Model());

            ColorLabel = labelHSVval;
            ColorPanel = panelColor;

            RedThrottle = 43.75;
            propertyGrid.BrowsableAttributes = new AttributeCollection(new CategoryAttribute("User Parameters"));
            propertyGrid.SelectedObject = this;

            vScrollBarHSV.ValueChanged += delegate { SetColorHSV?.Invoke(vScrollBarHSV, EventArgs.Empty); };
        }
    }
}
