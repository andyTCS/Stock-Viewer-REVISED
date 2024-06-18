using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Viewer
{
    public class marubozuRecognizer : recognizer
    {
        // Logic for marubozu pattern
        public override bool recognizePattern(smartCandlestick data)
        {
            // Check if the candle has no upper or lower shadows
            bool noUpperShadow = (data.High - Math.Max(data.Open, data.Close)) < 0.0001; // Tolerance for no upper shadow
            bool noLowerShadow = (Math.Min(data.Open, data.Close) - data.Low) < 0.0001; // Tolerance for no lower shadow

            // Check if the candle is bullish or bearish Marubozu
            bool isBullishMarubozu = (data.Close - data.Open) > 0.0001; // Tolerance for bullish Marubozu
            bool isBearishMarubozu = (data.Open - data.Close) > 0.0001; // Tolerance for bearish Marubozu

            return (noUpperShadow && noLowerShadow) && (isBullishMarubozu || isBearishMarubozu);
        }

        // Get type of recognizer if pattern is right
        public override string getRecognizerType(bool pattern)
        {
            if (pattern)
            {
                return "Marubozu";
            }
            else { return ""; }
        }

        // Set color attribute for use with arrow annotation
        public override Color patternColor
        {
            get { return Color.Magenta; }
        }
    }
}
