using System;
using System.Drawing;

namespace RGBLED
{
    public class Model : IModel
    {
        private Brainboxes.IO.EDDevice RGB_Controller { get; set; }
        public int HSV { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public void Initialize(string portString)
        {
            RGB_Controller = Brainboxes.IO.EDDevice.Create(portString);
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
