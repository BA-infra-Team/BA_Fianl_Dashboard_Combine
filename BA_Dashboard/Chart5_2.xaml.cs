using System;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace BA_Dashboard
{
    /// <summary>
    /// Chart5_2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart5_2 : UserControl
    {
        public Chart5_2()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Count",
                    Values = new ChartValues<ObservableValue> {
                        new ObservableValue(ChartData.JobType_PieChart_File_Backup_Count),
                        new ObservableValue(ChartData.JobType_PieChart_Informix_Onbar_Backup_Count),
                        new ObservableValue(ChartData.JobType_PieChart_Mysql_Backup_Count),
                        new ObservableValue(ChartData.JobType_PieChart_Oracle_RMAN_Backup_Count),
                        new ObservableValue(ChartData.JobType_PieChart_Physical_Backup_Count),
                        new ObservableValue(ChartData.JobType_PieChart_Vm_Ware_Backup_Count),
                    },
                    DataLabels = true,
                    //Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#805EFD"))
                },
            };

            Labels = new[] { "File Backup", "Informix Onbar Backup", "Mysql Backup", "Oracle RMAN Backup", "Physical Backup", "VmWare Backup" };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
}