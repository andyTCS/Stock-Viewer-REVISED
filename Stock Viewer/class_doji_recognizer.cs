using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Viewer
{
    public class dojiRecognizer : recognizer
    {
        // Logic for the pattern
        public override bool recognizePattern(smartCandlestick data)
        {
            bool isDoji = Math.Abs(data.Open - data.Close) < 0.0001;
            return isDoji;
        }

        // Return the recognizer type if the pattern matches
        public override string getRecognizerType(bool pattern)
        {
            if (pattern)
            {
                return "Doji";
            }
            else { return ""; }
        }

        // Color attribute to be used with arrow annotation
        public override Color patternColor
        {
            get { return Color.Blue; }
        }
    }
}
