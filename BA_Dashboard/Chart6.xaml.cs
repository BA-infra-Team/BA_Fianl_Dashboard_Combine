using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;
using System.Windows.Media;


namespace BA_Dashboard
{
    /// <summary>
    /// Chart6.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart6 : UserControl
    {
        public Chart6()
        {
            InitializeComponent();
            SeriesCollection1 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Archive Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Archive_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#FB71DE"))
                },
                new PieSeries
                {
                    Title = "Cumulative Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Cumulative_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#D966E3"))

                },
                new PieSeries
                {
                    Title = "Differential Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Differential_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#D97EFA"))
                },
                new PieSeries
                {
                    Title = "Dump Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Dump_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#AA66E3"))
                },
                new PieSeries
                {
                    Title = "Enterprise Differential Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Enterprise_Differential_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#9154FF"))

                },
                new PieSeries
                {
                    Title = "Enterprise Full Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Enterprise_Full_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#B1FAFA"))

                },
                new PieSeries
                {
                    Title = "Enterprise Incremental Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Enterprise_Incremental_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#8ED0E6"))
                },
                new PieSeries
                {
                    Title = "Full Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Full_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#A6D2FA"))
                },

                new PieSeries
                {
                    Title = "Increamental Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Incremental_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#9EB2E6"))
                },

                new PieSeries
                {
                    Title = "Synthetic Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Backup_Method_Ratio_Pie_Chart_Synthetic_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#999CFF"))
                }
            };

            DataContext = this;
        }


        public SeriesCollection SeriesCollection1 { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
}
