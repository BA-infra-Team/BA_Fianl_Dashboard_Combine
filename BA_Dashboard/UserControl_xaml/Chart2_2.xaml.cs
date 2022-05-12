using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace BA_Dashboard
{
    /// <summary>
    /// Chart2_2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart2_2 : INotifyPropertyChanged
    {
        private Func<double, string> _yFormatter;
        public Chart2_2()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new StackedAreaSeries
                {
                    Title = "일일 백업 처리 수",
                    Values = new ChartValues<int>
                    {
                        ChartData.Total_Backup_Count_LineChart_2022_02_08_Completed_Count,
                        ChartData.Total_Backup_Count_LineChart_2022_02_09_Completed_Count,
                        ChartData.Total_Backup_Count_LineChart_2022_02_10_Completed_Count,
                        ChartData.Total_Backup_Count_LineChart_2022_02_11_Completed_Count,
                        ChartData.Total_Backup_Count_LineChart_2022_02_12_Completed_Count,
                        ChartData.Total_Backup_Count_LineChart_2022_02_13_Completed_Count,
                        ChartData.Total_Backup_Count_LineChart_2022_02_14_Completed_Count,
                        ChartData.Total_Backup_Count_LineChart_2022_02_15_Completed_Count
                    },
                    LineSmoothness = 0
                },
                new StackedAreaSeries
                {
                    Title = "일일 백업 파일 수",
                    Values = new ChartValues<int>
                    {
                        ChartData.Total_File_Size_LineChart_2022_02_08_Count,
                        ChartData.Total_File_Size_LineChart_2022_02_09_Count,
                        ChartData.Total_File_Size_LineChart_2022_02_10_Count,
                        ChartData.Total_File_Size_LineChart_2022_02_11_Count,
                        ChartData.Total_File_Size_LineChart_2022_02_12_Count,
                        ChartData.Total_File_Size_LineChart_2022_02_13_Count,
                        ChartData.Total_File_Size_LineChart_2022_02_14_Count,
                        ChartData.Total_File_Size_LineChart_2022_02_15_Count
                    },
                    LineSmoothness = 0
                },
            };

            Labels = new[] { "22.02.08", "22.02.09", "22.02.10", "22.02.11", "22.02.12", "22.02.13", "22.02.14", "22.02.15" };
            YFormatter = val => val.ToString("N");
            DataContext = this;
        }
        public string[] Labels { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public Func<double, string> YFormatter
        {
            get { return _yFormatter; }
            set
            {
                _yFormatter = value;
                OnPropertyChanged();
            }
        }

        public StackMode StackMode { get; set; }

        private void ChangeStackModeOnClick(object sender, RoutedEventArgs e)
        {
            foreach (var series in SeriesCollection.Cast<StackedAreaSeries>())
            {
                series.StackMode = series.StackMode == StackMode.Percentage
                    ? StackMode.Values
                    : StackMode.Percentage;
            }

            if (((StackedAreaSeries)SeriesCollection[0]).StackMode == StackMode.Values)
            {
                YFormatter = val => val.ToString("N");
            }
            else
            {
                YFormatter = val => val.ToString("P");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
