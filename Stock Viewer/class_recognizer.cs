using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Viewer
{
    public abstract class recognizer
    {
        // Logic for pattern recognition
        public abstract bool recognizePattern(smartCandlestick data);

        // Get the pattern type if pattern is true. Pass in recognizePattern()
        public abstract string getRecognizerType(bool pattern);

        // Color attribute for annotation use
        public abstract Color patternColor { get; }
    }
}
