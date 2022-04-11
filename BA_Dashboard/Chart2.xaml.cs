using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;

namespace BA_Dashboard
{
    /// <summary>
    /// Chart2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart2 : UserControl
    {
        public Chart2()
        {
            InitializeComponent();

            SeriesCollection1 = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "일일 백업 처리 수",
                    Values = new ChartValues<int> { ChartData.Total_Backup_Count_LineChart_2022_02_08_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_09_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_10_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_11_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_12_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_13_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_14_Completed_Count,
                                                        ChartData.Total_Backup_Count_LineChart_2022_02_15_Completed_Count}
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection1.Add(new ColumnSeries
            {
                Title = "일일 파일 처리 수",
                Values = new ChartValues<int> { ChartData.Total_File_Size_LineChart_2022_02_08_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_09_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_10_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_11_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_12_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_13_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_14_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_15_Count},
                Fill = System.Windows.Media.Brushes.LightBlue,
            });


            //SeriesCollection1[1].Values.Add(4d);
            Labels = new[] { "22.02.08", "22.02.09", "22.02.10", "22.02.11", "22.02.12", "22.02.13", "22.02.14", "22.02.15" };
            YFormatter = value => value.ToString("N");
            DataContext = this;
        }


        public SeriesCollection SeriesCollection1 { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
    
}
