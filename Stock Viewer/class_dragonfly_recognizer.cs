using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Viewer
{
    public class dragonflyRecognizer : recognizer
    {
        // Logic for pattern recognition
        public override bool recognizePattern(smartCandlestick data)
        {
            // Check if the candle has no upper shadow
            bool noUpperShadow = (data.High - Math.Max(data.Open, data.Close)) < 0.0001; // Tolerance for no upper shadow
            bool isDoji = Math.Abs(data.Open - data.Close) < 0.0001;

            // Check if criteria met for Dragonfly 
            return noUpperShadow && isDoji && (data.Low - Math.Min(data.Open, data.Close)) < 0.0001; // Tolerance for a long lower shadow
        }

        // Returntype of recognizer if the pattern is right
        public override string getRecognizerType(bool pattern)
        {
            if (pattern)
            {
                return "Dragonfly";
            }
            else { return ""; }
        }

        // Set attribute for arrow annotation color
        public override Color patternColor
        {
            get { return Color.Indigo; }
        }
    }
}
