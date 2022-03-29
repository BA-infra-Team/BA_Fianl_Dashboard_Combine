using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace BA_Dashboard
{
    /// <summary>
    /// row_1_col_1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class row_1_col_1 : UserControl
    {
        public row_1_col_1()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "File Size",
                    Values = new ChartValues<int> { ChartData.Total_File_Size_LineChart_2022_02_08_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_09_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_10_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_11_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_12_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_13_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_14_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_15_Count}

                },

                 new LineSeries
                {
                    Title = "Write Size",
                    Values = new ChartValues<int> { ChartData.Total_Write_Size_LineChart_2022_02_08_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_09_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_10_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_11_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_12_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_13_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_14_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_15_Count}

                },

                  new LineSeries
                {
                    Title = "Transferred Data",
                    Values = new ChartValues<int> { ChartData.Total_Data_Transferred_LineChart_2022_02_08_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_09_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_10_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_11_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_12_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_13_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_14_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_15_Count}

                },


            };

            Labels = new[] { "22.02.08", "22.02.09", "22.02.10", "22.02.11", "22.02.12", "22.02.13", "22.02.14", "22.02.15" };
            YFormatter = value => value.ToString("N");
            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}
