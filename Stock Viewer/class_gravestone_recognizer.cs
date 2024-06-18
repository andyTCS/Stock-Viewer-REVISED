using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Viewer
{
    public class gravestoneRecognizer : recognizer
    {
        // Logic for pattern recognition
        public override bool recognizePattern(smartCandlestick data)
        {
            // Check if the candle has no lower shadow
            bool noLowerShadow = (Math.Min(data.Open, data.Close) - data.Low) < 0.0001; // Tolerance for no lower shadow
            bool isDoji = Math.Abs(data.Open - data.Close) < 0.0001;

            // Check if criteria for Gravestone Doji is met
            return noLowerShadow && isDoji && (data.High - Math.Max(data.Open, data.Close)) < 0.0001; // Tolerance for a long upper shadow
        }

        // Give type of recognizer if the pattern matches
        public override string getRecognizerType(bool pattern)
        {
            if (pattern)
            {
                return "Gravestone";
            }
            else { return ""; }
        }

        // Set attribute for arrow annotation colo
        public override Color patternColor
        {
            get { return Color.Gray; }
        }
    }
}
