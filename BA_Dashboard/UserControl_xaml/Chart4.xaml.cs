using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;
using System.Windows.Media;


namespace BA_Dashboard
{
    /// <summary>
    /// Chart4.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart4 : UserControl
    {
        public Chart4()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {

                new PieSeries
                {
                    Title = "Canceled",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Canceled_Error_Count) },
                    DataLabels = true,
                    FontSize = 50,
                    Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#143F6B"))
        },
                new PieSeries
                {
                    Title = "Failed",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Failed_Error_Count) },
                    DataLabels = true,
                    Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F55353"))
                },
                new PieSeries
                {
                    Title = "Partially Completed",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Partially_Completed_Count) },
                    DataLabels = true,
                    Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#82C0FA"))
                },

                new PieSeries
                {
                    Title = "Suspend",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Suspended_Error_Count) },
                    DataLabels = true,
                    Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#8A6EFA"))
                }
            };

            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
    
}
