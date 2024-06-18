using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Viewer
{
    public class neutralRecognizer : recognizer
    {
        // Set tolerance to use with neutral logic
        double setTolerance(double tolerance = 0.05)
        {
            double result = tolerance;
            return result;
        }

        // Logic for neutral pattern
        public override bool recognizePattern(smartCandlestick data)
        {
            return Math.Abs(data.Close - data.Open) <= Math.Abs(data.Open * setTolerance());
        }

        // Get recognizer type if the pattern matches
        public override string getRecognizerType(bool pattern)
        {
            if (pattern)
            {
                return "Neutral";
            }
            else { return ""; }
        }

        // Set color attribute to use with arrow annotation
        public override Color patternColor
        {
            get { return Color.Black; }
        }
    }
}
