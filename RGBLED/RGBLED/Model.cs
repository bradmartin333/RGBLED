using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBLED
{
    public class Model : IModel
    {
        public int HSV { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public double Throttle { get; set; } = 43.75;
        public string PortString { get; set; } = "192.168.1.11";
        private Brainboxes.IO.EDDevice RGB_Controller { get; set; }
        private readonly System.Windows.Forms.Timer BrainboxesTimout = new System.Windows.Forms.Timer
        {
            Interval = 1000,
            Enabled = false,
        };
        private CancellationTokenSource TokenSource = new CancellationTokenSource();

        public bool Initialize()
        {
            CancellationToken token = TokenSource.Token;
            TaskFactory factory = new TaskFactory(token);
            Task task = factory.StartNew(() => RGB_Controller = Brainboxes.IO.EDDevice.Create(PortString));
            BrainboxesTimout.Tick += BrainboxesTimout_Tick;
            BrainboxesTimout.Enabled = true;
            BrainboxesTimout.Start();
            while (BrainboxesTimout.Enabled)
                Application.DoEvents();
            return !(RGB_Controller == null);
        }

        private void BrainboxesTimout_Tick(object sender, EventArgs e)
        {
            TokenSource.Cancel();
            BrainboxesTimout.Tick -= BrainboxesTimout_Tick;
            BrainboxesTimout.Enabled = false;
            BrainboxesTimout.Stop();

            if (RGB_Controller == null)
                MessageBox.Show("Port not valid, please check network adapter and port in settings panel.", "RGBLED");
            else
                ClearColor();
        }

        public void Close()
        {
            RGB_Controller?.Dispose();
        }

        public void SetColor()
        {
            Color c = ColorFromHSV(HSV);
            R = c.R;
            G = c.G;
            B = c.B;
        }

        public void ClearColor()
        {
            // Set all channels to 5V
            // All output channels = reference voltage = 100% dimmed
            RGB_Controller.AOutputs.AValues = 5;
        }

        public Color ColorFromHSV(double hue, double value = 1, double saturation = 1)
        {
            if (hue == 360) return Color.FromArgb(255, Color.White);
            if (hue == 0) return Color.FromArgb(255, Color.Black);

            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value *= 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        public double Map(double value, double fromLow = 0, double fromHigh = 255, double toLow = 4.5, double toHigh = 1)
        {
            // Based on the BuckPuck datasheet, mapping to 1V - 4.5V will get the full range without waste
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }
    }
}
