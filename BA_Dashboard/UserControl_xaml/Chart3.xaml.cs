using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;


namespace BA_Dashboard
{
    /// <summary>
    /// Chart3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart3 : UserControl
    {
        public Chart3()
        {
            InitializeComponent();

            SeriesCollection1 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Completed",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Total_Error_Ratio_PieChart_Total_Completed_Count) },
                    DataLabels = true,
                    Fill = System.Windows.Media.Brushes.RoyalBlue,
                },
                new PieSeries
                {
                    Title = "Canceled",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Total_Error_Ratio_PieChart_Total_Error_Count) },
                    DataLabels = true,
                    Fill = System.Windows.Media.Brushes.OrangeRed,
                },

            };

            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection1 { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
    
}
