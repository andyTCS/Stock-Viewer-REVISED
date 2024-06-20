namespace Stock_Viewer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_price = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_volume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_candleStick_pattern_dropDown = new System.Windows.Forms.ComboBox();
            this.label_comboBox_candlestick_pattern = new System.Windows.Forms.Label();
            this.button_clear_annotations = new System.Windows.Forms.Button();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label_dateTime_start = new System.Windows.Forms.Label();
            this.label_dateTime_end = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.label_chart_price = new System.Windows.Forms.Label();
            this.label_chart_volume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_price
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_price.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_price.Legends.Add(legend1);
            this.chart_price.Location = new System.Drawing.Point(58, 71);
            this.chart_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_price.Name = "chart_price";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "Daily OHLC";
            series1.YValuesPerPoint = 4;
            this.chart_price.Series.Add(series1);
            this.chart_price.Size = new System.Drawing.Size(1233, 462);
            this.chart_price.TabIndex = 0;
            this.chart_price.Text = "Price Chart";
            // 
            // chart_volume
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_volume.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_volume.Legends.Add(legend2);
            this.chart_volume.Location = new System.Drawing.Point(58, 582);
            this.chart_volume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart_volume.Name = "chart_volume";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Volume";
            this.chart_volume.Series.Add(series2);
            this.chart_volume.Size = new System.Drawing.Size(1233, 462);
            this.chart_volume.TabIndex = 1;
            this.chart_volume.Text = "Volume Chart";
            // 
            // comboBox_candleStick_pattern_dropDown
            // 
            this.comboBox_candleStick_pattern_dropDown.FormattingEnabled = true;
            this.comboBox_candleStick_pattern_dropDown.Location = new System.Drawing.Point(1348, 80);
            this.comboBox_candleStick_pattern_dropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_candleStick_pattern_dropDown.Name = "comboBox_candleStick_pattern_dropDown";
            this.comboBox_candleStick_pattern_dropDown.Size = new System.Drawing.Size(180, 28);
            this.comboBox_candleStick_pattern_dropDown.TabIndex = 2;
            this.comboBox_candleStick_pattern_dropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox_candleStick_pattern_dropDown_SelectedIndexChanged);
            // 
            // label_comboBox_candlestick_pattern
            // 
            this.label_comboBox_candlestick_pattern.AutoSize = true;
            this.label_comboBox_candlestick_pattern.Location = new System.Drawing.Point(1344, 46);
            this.label_comboBox_candlestick_pattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_comboBox_candlestick_pattern.Name = "label_comboBox_candlestick_pattern";
            this.label_comboBox_candlestick_pattern.Size = new System.Drawing.Size(147, 20);
            this.label_comboBox_candlestick_pattern.TabIndex = 3;
            this.label_comboBox_candlestick_pattern.Text = "Candlestick Pattern";
            // 
            // button_clear_annotations
            // 
            this.button_clear_annotations.Location = new System.Drawing.Point(1558, 80);
            this.button_clear_annotations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_clear_annotations.Name = "button_clear_annotations";
            this.button_clear_annotations.Size = new System.Drawing.Size(148, 82);
            this.button_clear_annotations.TabIndex = 4;
            this.button_clear_annotations.Text = "Clear Annotations";
            this.button_clear_annotations.UseVisualStyleBackColor = true;
            this.button_clear_annotations.Click += new System.EventHandler(this.button_clear_annotations_Click);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(1347, 415);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker_start.TabIndex = 5;
            this.dateTimePicker_start.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(1347, 582);
            this.dateTimePicker_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker_end.TabIndex = 6;
            this.dateTimePicker_end.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label_dateTime_start
            // 
            this.label_dateTime_start.AutoSize = true;
            this.label_dateTime_start.Location = new System.Drawing.Point(1342, 374);
            this.label_dateTime_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dateTime_start.Name = "label_dateTime_start";
            this.label_dateTime_start.Size = new System.Drawing.Size(83, 20);
            this.label_dateTime_start.TabIndex = 7;
            this.label_dateTime_start.Text = "Start Date";
            // 
            // label_dateTime_end
            // 
            this.label_dateTime_end.AutoSize = true;
            this.label_dateTime_end.Location = new System.Drawing.Point(1342, 542);
            this.label_dateTime_end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dateTime_end.Name = "label_dateTime_end";
            this.label_dateTime_end.Size = new System.Drawing.Size(77, 20);
            this.label_dateTime_end.TabIndex = 8;
            this.label_dateTime_end.Text = "End Date";
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.ForeColor = System.Drawing.Color.Red;
            this.label_note.Location = new System.Drawing.Point(1344, 191);
            this.label_note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(56, 20);
            this.label_note.TabIndex = 9;
            this.label_note.Text = "NOTE:";
            // 
            // textBox_note
            // 
            this.textBox_note.Location = new System.Drawing.Point(1347, 215);
            this.textBox_note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_note.Multiline = true;
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(358, 104);
            this.textBox_note.TabIndex = 10;
            this.textBox_note.Text = "The Candlestick Pattern dropdown box only shows available patterns found from the" +
    " candlesticks in the CSV files. Different files may show different available can" +
    "dlestick patterns.";
            // 
            // label_chart_price
            // 
            this.label_chart_price.AutoSize = true;
            this.label_chart_price.Location = new System.Drawing.Point(600, 46);
            this.label_chart_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_chart_price.Name = "label_chart_price";
            this.label_chart_price.Size = new System.Drawing.Size(87, 20);
            this.label_chart_price.TabIndex = 11;
            this.label_chart_price.Text = "Chart Price";
            // 
            // label_chart_volume
            // 
            this.label_chart_volume.AutoSize = true;
            this.label_chart_volume.Location = new System.Drawing.Point(600, 557);
            this.label_chart_volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_chart_volume.Name = "label_chart_volume";
            this.label_chart_volume.Size = new System.Drawing.Size(106, 20);
            this.label_chart_volume.TabIndex = 12;
            this.label_chart_volume.Text = "Chart Volume";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2028, 1217);
            this.Controls.Add(this.label_chart_volume);
            this.Controls.Add(this.label_chart_price);
            this.Controls.Add(this.textBox_note);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.label_dateTime_end);
            this.Controls.Add(this.label_dateTime_start);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.button_clear_annotations);
            this.Controls.Add(this.label_comboBox_candlestick_pattern);
            this.Controls.Add(this.comboBox_candleStick_pattern_dropDown);
            this.Controls.Add(this.chart_volume);
            this.Controls.Add(this.chart_price);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_price;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_volume;
        private System.Windows.Forms.ComboBox comboBox_candleStick_pattern_dropDown;
        private System.Windows.Forms.Label label_comboBox_candlestick_pattern;
        private System.Windows.Forms.Button button_clear_annotations;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label label_dateTime_start;
        private System.Windows.Forms.Label label_dateTime_end;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.Label label_chart_price;
        private System.Windows.Forms.Label label_chart_volume;
    }
}