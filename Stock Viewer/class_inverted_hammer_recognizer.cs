using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Viewer
{
    public class invertedHammerRecognizer : recognizer
    {
        // Logic for inverted hammer recognizer
        public override bool recognizePattern(smartCandlestick data)
        {
            // Calculate the body and upper/lower shadows
            double body = Math.Abs(data.Open - data.Close);
            double upperShadow = data.High - Math.Max(data.Open, data.Close);
            double lowerShadow = Math.Min(data.Open, data.Close) - data.Low;

            // Check if the candle is an Inverted Hammer
            bool isInvertedHammer = body < (0.3 * Math.Abs(data.Open - data.Close)) && // Tolerance for body size
                upperShadow >= 2 * body &&  // Upper shadow is at least twice the body
                lowerShadow <= 0.1 * body; // Lower shadow is small or non-existent

            return isInvertedHammer;
        }

        // Give recognizer type if pattern is correct
        public override string getRecognizerType(bool pattern)
        {
            if (pattern)
            {
                return "Inverted Hammer";
            }
            else { return ""; }
        }

        // Set color attribute for use with arrow annotation
        public override Color patternColor
        {
            get { return Color.Maroon; }
        }
    }
}
