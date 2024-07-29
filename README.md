# Stock Viewer REVISED
Revised version of my stock viewer project. Refactored to be more readable

Program description:

    This program offers selection of multiple CSV files to be used for stock data analysis.
    
    A folder of CSV files are already included within the files of this program to be used for demonstration purposes. These files were obtained from Yahoo Finances.
    More files can be obtained and downloaded for analysis from the website from within the 'Historical Data' tab.

How this program works:

    Download the folder and then access the Debug folder from within the bin folder.
        Example path: ......\Stock-Viewer-REVISED\Stock Viewer\bin\Debug
    
    Run the executable file and click the 'Load CSV' button. Multiple files can be selected.
    
    A chart containing a bar graph of the loaded CSV file will be displayed. This top chart displays the open, high, low, and close values.
    
    A chart beneath represents the volume of the current stock loaded.
    
    You may change the dates to filter data from within the date period you have selected. This will dynamically filter the charts as you change dates.
    
    Interacting with the 'Candlestick Pattern' drop-down menu displays a list of recognized candlestick patterns from the charts.
        Selecting a pattern will show exactly where that pattern exists on the charts.
    
    Clicking on the 'Clear Annotation' button will remove any existing candlestick pattern being shown on the chart.
