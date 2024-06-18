using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Viewer
{
    public class bullishRecognizer : recognizer
    {
        // Logic for the pattern
        public override bool recognizePattern(smartCandlestick data)
        {
            return data.Close > data.Open;
        }

        // Return the recognizer type if the pattern matches
        public override string getRecognizerType(bool pattern)
        {
            if (pattern)
            {
                return "Bullish";
            }
            else { return ""; }
        }

        // Color attribute to be used with arrow annotation
        public override Color patternColor
        {
            get { return Color.Green; }
        }
    }
}
