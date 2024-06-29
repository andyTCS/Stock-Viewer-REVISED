using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Stock_Viewer
{
    public partial class Form2 : Form
    {
        private List<smartCandlestick> this_forms_smartCandlesticks;                                            // List of candlesticks to be set to form1's passed through list of candlesticks

        private List<recognizer> this_forms_recognizers = new List<recognizer> {                                //  List of available recognizers
                new bullishRecognizer(),
                new bearishRecognizer(),
                new dojiRecognizer(),
                new dragonflyRecognizer(),
                new gravestoneRecognizer(),
                new hammerRecognizer(),
                new invertedHammerRecognizer(),
                new marubozuRecognizer(),
                new neutralRecognizer(),
        };

        public Form2(List<smartCandlestick> list_of_smartCandlesticks)
        {
            InitializeComponent();
            this.Text = "Stock Viewer";

            this_forms_smartCandlesticks = list_of_smartCandlesticks;
            populate_Chart_Daily(this_forms_smartCandlesticks);
            populate_Chart_Volume(this_forms_smartCandlesticks);
            populate_ComboBox_Patterns(this_forms_smartCandlesticks);

            initialize_datetime_start();
            intialize_datetime_end();
        }

        // Event to handle when used interacts with the starting date time picker
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Check if allData is null or empty (no CSV file loaded)
            if (this_forms_smartCandlesticks == null || this_forms_smartCandlesticks.Count == 0)
            {
                MessageBox.Show("Please select a CSV file first.", "CSV File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chart_price.Annotations.Clear();                                                                    // Clear annotations if they exist when the user alters dates

            DateTime startDate = dateTimePicker_start.Value.Date;
            DateTime endDate = dateTimePicker_end.Value.Date;
            check_datetime_bounds(startDate, endDate);

            // Filter data based on the selected date rangecheck_datetime_bounds(startDate, endDate);
            var filtered_smartCandlesticks = this_forms_smartCandlesticks.Where(data => data.Date >= startDate && data.Date <= endDate).ToList();

            //Populate chart here and update to filtered candlesticks
            populate_Chart_Daily(filtered_smartCandlesticks);
            populate_Chart_Volume(filtered_smartCandlesticks);
            populate_ComboBox_Patterns(filtered_smartCandlesticks);
        }

        // Event to handle when used interacts with the ending date time picker
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // Check if allData is null or empty (no CSV file loaded)
            if (this_forms_smartCandlesticks == null || this_forms_smartCandlesticks.Count == 0)
            {
                MessageBox.Show("Please select a CSV file first.", "CSV File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chart_price.Annotations.Clear();                                                                    // Clear annotations if they exist when the user alters dates

            DateTime startDate = dateTimePicker_start.Value.Date;
            DateTime endDate = dateTimePicker_end.Value.Date;
            check_datetime_bounds(startDate, endDate);

            var filtered_smartCandlesticks = this_forms_smartCandlesticks.Where(data => data.Date >= startDate && data.Date <= endDate).ToList();

            //Populate chart here and update to filtered candlesticks
            populate_Chart_Daily(filtered_smartCandlesticks);
            populate_Chart_Volume(filtered_smartCandlesticks);
            populate_ComboBox_Patterns(filtered_smartCandlesticks);
        }

        private void button_clear_annotations_Click(object sender, EventArgs e)
        {
            chart_price.Annotations.Clear();
        }

        private void comboBox_candleStick_pattern_dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_pattern = comboBox_candleStick_pattern_dropDown.SelectedItem.ToString();
            foreach (var smartCandlestick in this_forms_smartCandlesticks) {
                foreach (var recognizer in this_forms_recognizers) {
                    foreach (DataPoint data_point in chart_price.Series["Daily OHLC"].Points){

                        bool match_pattern = recognizer.recognizePattern(smartCandlestick);
                        if (recognizer.getRecognizerType(match_pattern) == selected_pattern) {
                            DateTime xValueDate = DateTime.FromOADate(data_point.XValue);
                            string formattedXValue = xValueDate.ToShortDateString();
                            if (smartCandlestick.Date.ToShortDateString() == formattedXValue && recognizer.recognizePattern(smartCandlestick)) {
                                ArrowAnnotation arrowAnnotation = new ArrowAnnotation
                                {
                                    Width = 2,
                                    Height = -1,
                                    LineWidth = 2,
                                    AnchorDataPoint = data_point,
                                    AnchorOffsetY = 0,
                                    Alignment = ContentAlignment.TopCenter,
                                    Font = new Font("Arial", 10),
                                    LineColor = recognizer.patternColor
                                };
                                chart_price.Annotations.Add(arrowAnnotation);
                            }
                        }
                    }
                }
            }
        }

        // ---------    Functions not generated by Visual Studios    --------- //

        public void populate_Chart_Daily(List<smartCandlestick> data)
        {
            chart_price.Series["Daily OHLC"].Points.Clear();

            chart_price.DataSource = data;                                                                      // Binding the x axis of the chart to dates and open, high, low, close to y axis
            chart_price.Series["Daily OHLC"].XValueMember = "Date";
            chart_price.Series["Daily OHLC"].YValueMembers = "High,Low,Open,Close";
            chart_price.DataBind();

            if (data.Count >= 1) { label_chart_price.Text = data[0].Ticker.ToString() + " Price"; }             // Label the chart using the ticker member of a candlestick

            int index = 0;
            foreach (DataPoint point in chart_price.Series["Daily OHLC"].Points) {                              // Traverse each candlestick mapped by the charts and determine if they're bullish or bearish
                if (index < data.Count) {                                                                       // The chart will display these candlesticks 
                    smartCandlestick item = data[index];
                    bullishRecognizer bullish = new bullishRecognizer();
                    bearishRecognizer bearish = new bearishRecognizer();

                    if (bullish.recognizePattern(item)) { point.Color = bullish.patternColor; }
                    else if (bearish.recognizePattern(item)) { point.Color = bearish.patternColor; }
                    else { point.Color = Color.Gray; }

                    index++;
                }
            }

            chart_price.ChartAreas[0].AxisY.Title = "Price";
            
        }

        public void populate_Chart_Volume(List<smartCandlestick> data) 
        {
            chart_volume.Series["Volume"].Points.Clear();

            chart_volume.DataSource = data;
            chart_volume.Series["Volume"].XValueMember = "Date";
            chart_volume.Series["Volume"].YValueMembers = "Volume";
            chart_volume.DataBind();

            if (data.Count >= 1) { label_chart_volume.Text = data[0].Ticker.ToString() + " Volume"; }

            int index = 0; // Initialize index

            foreach (DataPoint point in chart_volume.Series["Volume"].Points)
            {
                if (index < data.Count)
                {
                    smartCandlestick item = data[index];
                    bullishRecognizer bullish = new bullishRecognizer();
                    bearishRecognizer bearish = new bearishRecognizer();

                    if (bullish.recognizePattern(item)) { point.Color = bullish.patternColor; }
                    else if (bearish.recognizePattern(item)) { point.Color = bearish.patternColor; }
                    else { point.Color = Color.Gray; }

                    index++;
                }
            }

            chart_volume.ChartAreas[0].AxisY.Title = "Volume";
        }

        public void populate_ComboBox_Patterns(List<smartCandlestick> data) 
        {
            comboBox_candleStick_pattern_dropDown.Items.Clear();

            HashSet<string> unique_patterns = new HashSet<string>();                                            // Using HashSet for containing unique string elements for the comboBox

            foreach (var smartCandlestick in data){
                foreach (var recognizer in this_forms_recognizers) {
                    bool match_pattern = recognizer.recognizePattern(smartCandlestick);
                    if (match_pattern) {
                        unique_patterns.Add(recognizer.getRecognizerType(match_pattern));
                    }
                }
            }

            foreach (var pattern in unique_patterns) {
                comboBox_candleStick_pattern_dropDown.Items.Add(pattern);
            }
        }

        // This function makes it so that the starting date time picker defaults to 2021, 1, 1
        public void initialize_datetime_start() 
        {
            if (dateTimePicker_start != null)
            {
                dateTimePicker_start.Value = new DateTime(2021, 1, 1);
            }
        }


        // This function makes it so that the starting date time picker defaults to the current date
        public void intialize_datetime_end()
        {
            if (dateTimePicker_start != null)
            {
                dateTimePicker_end.Value = DateTime.Now;
            }
        }

        // If a user attempts to select a date beyond the current date, the date is set to the current date
        public void check_datetime_bounds(DateTime start, DateTime end)
        {
            if (start > DateTime.Now)
            {
                dateTimePicker_start.Value = DateTime.Now;
            }
            if (end > DateTime.Now)
            {
                dateTimePicker_end.Value = DateTime.Now;
            }
        }


        // ---------  ^ Functions not generated by Visual Studios ^  --------- //
    }
}
