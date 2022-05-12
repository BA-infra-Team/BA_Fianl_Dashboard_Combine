using System;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace BA_Dashboard
{
    /// <summary>
    /// Chart6_2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart6_2 : UserControl
    {
        public Chart6_2()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Title = "Archive_Backup",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Archive_Backup_Count },
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },

                new StackedColumnSeries
                {
                    Title = "Cumulative_Backup",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Cumulative_Backup_Count },
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "Differential_Backup",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Differential_Backup_Count },
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "Dump_Backup",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Dump_Backup_Count },
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "Enterprise_Differential_Backup",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Enterprise_Differential_Backup_Count },
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "Enterprise_Full_Backup",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Enterprise_Full_Backup_Count },
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "Enterprise_Incremental_Backup",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Enterprise_Incremental_Backup_Count},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "Full_Backup",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Full_Backup_Count},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "Incremental_Backup",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Incremental_Backup_Count},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Title = "Synthetic",
                    Values = new ChartValues<double> {ChartData.Backup_Method_Ratio_Pie_Chart_Synthetic_Count },
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
            };

            Labels = new[] { "Backup Method" };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
}