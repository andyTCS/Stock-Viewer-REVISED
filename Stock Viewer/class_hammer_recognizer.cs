using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Viewer
{
    public class hammerRecognizer : recognizer
    {
        // Logic for hammer pattern
        public override bool recognizePattern(smartCandlestick data)
        {
            // Calculate the body and upper/lower shadows
            double body = Math.Abs(data.Open - data.Close);
            double upperShadow = data.High - Math.Max(data.Open, data.Close);
            double lowerShadow = Math.Min(data.Open, data.Close) - data.Low;

            // Check if the candle is a Hammer
            bool isHammer = body < (0.3 * Math.Abs(data.Open - data.Close)) && // Tolerance for body size
                           lowerShadow >= 2 * body &&  // Lower shadow is at least twice the body
                           upperShadow <= 0.1 * body; // Upper shadow is small or nonexistent

            return isHammer;
        }

        // Give type of recognizer if pattern is correct
        public override string getRecognizerType(bool pattern)
        {
            if (pattern)
            {
                return "Hammer";
            }
            else { return ""; }
        }

        // Set color attribute for arrow annotation
        public override Color patternColor
        {
            get { return Color.Khaki; }
        }
    }
}
