using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;


namespace BA_Dashboard
{
    /// <summary>
    /// Chart1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart1 : UserControl
    {
        public Chart1()
        {
            InitializeComponent();
            
            SeriesCollection = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "Avg Elapsed Time",
                    Values = new ChartValues<int> { ChartData.Avg_Elapsed_Time_LineChart_2022_02_08_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_09_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_10_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_11_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_12_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_13_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_14_Avg_Elapsed_Times,
                                                        ChartData.Avg_Elapsed_Time_LineChart_2022_02_15_Avg_Elapsed_Times
                    }

                },

            };

            //SeriesCollection1[1].Values.Add(4d);
            Labels = new[] { "22.02.08", "22.02.09", "22.02.10", "22.02.11", "22.02.12", "22.02.13", "22.02.14", "22.02.15" };
            YFormatter = value => value.ToString("N");
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
    
}
