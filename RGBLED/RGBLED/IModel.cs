using System.Drawing;

namespace RGBLED
{
    public interface IModel
    {
        int HSV { get; set; }
        int R { get; set; }
        int G { get; set; }
        int B { get; set; }
        int W { get; set; }
        string PortString { get; set; }
        void SetColor();
        void ClearColor();
        void Close();
        Color ColorFromHSV(double hue, double value = 1, double saturation = 1);
        bool Initialize();
        double Map(double value, double fromLow = 0, double fromHigh = 255, double toLow = 4.5, double toHigh = 1);
    }
}