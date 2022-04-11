using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;
using System.Windows.Media;


namespace BA_Dashboard
{
    /// <summary>
    /// Chart5.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart5 : UserControl
    {
        public Chart5()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "File Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_File_Backup_Count) },
                    DataLabels = true,
                    Fill= (SolidColorBrush)(new BrushConverter().ConvertFrom("#805EFD"))

        },
                new PieSeries
                {
                    Title = "Informix Onbar Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Informix_Onbar_Backup_Count) },
                    DataLabels = true,
                    Fill=(SolidColorBrush)(new BrushConverter().ConvertFrom("#545CE3"))
                },
                new PieSeries
                {
                    Title = "Mysql Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Mysql_Backup_Count) },
                    DataLabels = true,
                    Fill=(SolidColorBrush)(new BrushConverter().ConvertFrom("#6996FA"))
                },
                new PieSeries
                {
                    Title = "Oracle RMAN Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Oracle_RMAN_Backup_Count) },
                    DataLabels = true,
                    Fill=(SolidColorBrush)(new BrushConverter().ConvertFrom("#54A7E3"))
                },

                new PieSeries
                {
                    Title = "Physical Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Physical_Backup_Count) },
                    DataLabels = true,
                    Fill=(SolidColorBrush)(new BrushConverter().ConvertFrom("#5EE4FD"))
                },

                new PieSeries
                {
                    Title = "VmWare Backup",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.JobType_PieChart_Vm_Ware_Backup_Count) },
                    DataLabels = true,
                    Fill=(SolidColorBrush)(new BrushConverter().ConvertFrom("#40C1FF"))
                    
                }
            };

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

    }
}
