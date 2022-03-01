using System;
using System.Windows.Forms;

namespace RGBLED
{
    public partial class View : Form, IView
    {
        public Label ColorLabel { get; set; }
        public Panel ColorPanel { get; set; }
        public VScrollBar ScrollBar { get; set; }
        public TextBox Port { get; set; }
        public NumericUpDown Throttle { get; set; }

        public event EventHandler SetColorHSV;
        public event EventHandler PortChanged;
        public event EventHandler PortConnectRequested;
        public event EventHandler ThrottleChanged;

        public View()
        {
            InitializeComponent();
            ColorLabel = LabelHSV;
            ColorPanel = PanelColor;
            ScrollBar = ScrollHSV;
            Port = TextBoxPort;
            Throttle = NumThrottle;
            ScrollHSV.ValueChanged += delegate { SetColorHSV?.Invoke(ScrollHSV, EventArgs.Empty); };
            TextBoxPort.TextChanged += delegate { PortChanged?.Invoke(TextBoxPort, EventArgs.Empty); };
            ButtonConnect.Click += delegate { PortConnectRequested?.Invoke(ButtonConnect, EventArgs.Empty); };
            NumThrottle.ValueChanged += delegate { ThrottleChanged?.Invoke(NumThrottle, EventArgs.Empty); };
            new Presenter(this, new Model());
        }
    }
}
