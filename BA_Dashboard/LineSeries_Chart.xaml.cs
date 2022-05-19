using System;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using System.ComponentModel;
using LiveCharts.Defaults;

namespace BA_Dashboard
{
    /// <summary>
    /// LineSeries_Chart.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LineSeries_Chart : UserControl, INotifyPropertyChanged
    {
        private bool _LegendVisibility;
        private bool _ColorToggle;
        private bool _DataToggle;

        private string _FileColorString;

        private bool _FileSizeSeriesVisibility;
        private bool _WriteSizeSeriesVisibility;
        private bool _TransferredVisibility;

        private bool _AllVisibility;

        #region 데이터변수
        public double[] File_Size_List = { ChartData.Total_File_Size_LineChart_2022_02_08_Count, ChartData.Total_File_Size_LineChart_2022_02_09_Count,
            ChartData.Total_File_Size_LineChart_2022_02_10_Count,ChartData.Total_File_Size_LineChart_2022_02_11_Count,ChartData.Total_File_Size_LineChart_2022_02_12_Count
            ,ChartData.Total_File_Size_LineChart_2022_02_13_Count,ChartData.Total_File_Size_LineChart_2022_02_14_Count,ChartData.Total_File_Size_LineChart_2022_02_15_Count};

        public double[] Write_Size_List = { ChartData.Total_Write_Size_LineChart_2022_02_08_Count, ChartData.Total_Write_Size_LineChart_2022_02_09_Count,
            ChartData.Total_Write_Size_LineChart_2022_02_10_Count,ChartData.Total_Write_Size_LineChart_2022_02_11_Count,ChartData.Total_Write_Size_LineChart_2022_02_12_Count
            ,ChartData.Total_Write_Size_LineChart_2022_02_13_Count,ChartData.Total_Write_Size_LineChart_2022_02_14_Count,ChartData.Total_Write_Size_LineChart_2022_02_15_Count};

        public double[] Trans_Size_List = { ChartData.Total_Data_Transferred_LineChart_2022_02_08_Count, ChartData.Total_Data_Transferred_LineChart_2022_02_09_Count,
            ChartData.Total_Data_Transferred_LineChart_2022_02_10_Count,ChartData.Total_Data_Transferred_LineChart_2022_02_11_Count,ChartData.Total_Data_Transferred_LineChart_2022_02_12_Count
            ,ChartData.Total_Data_Transferred_LineChart_2022_02_13_Count,ChartData.Total_Data_Transferred_LineChart_2022_02_14_Count,ChartData.Total_Data_Transferred_LineChart_2022_02_15_Count};
        #endregion
        public LineSeries_Chart()
        {
            InitializeComponent();

            ColorToggle = false;
            DataToggle = false;

            LegendVisibility = true;
            AllVisibility = true;
            FileSizeSeriesVisibility = true;
            WriteSizeSeriesVisibility = true;
            TransferredVisibility = true;

            FileColorString = "#ccdfff";

            File_Size_Values = new ChartValues<ObservableValue>();
            for (int i = 0; i < File_Size_List.Length; i++)
            {
                File_Size_Values.Add(new ObservableValue(File_Size_List[i]));
            }

            Write_Size_Values = new ChartValues<ObservableValue>();
            for (int i = 0; i < Write_Size_List.Length; i++)
            {
                Write_Size_Values.Add(new ObservableValue(Write_Size_List[i]));
            }

            Transferred_Values = new ChartValues<ObservableValue>();
            for (int i = 0; i < Trans_Size_List.Length; i++)
            {
                Transferred_Values.Add(new ObservableValue(Trans_Size_List[i]));
            }

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ChartValues<ObservableValue> File_Size_Values { get; set; }
        public ChartValues<ObservableValue> Write_Size_Values { get; set; }
        public ChartValues<ObservableValue> Transferred_Values { get; set; }

        public bool ColorToggle
        {
            get { return _ColorToggle; }
            set
            {
                _ColorToggle = value;
                OnPropertyChanged("ColorToggle");
            }
        }
        public bool DataToggle
        {
            get { return _DataToggle; }
            set
            {
                _DataToggle = value;
                OnPropertyChanged("DataToggle");
            }
        }

        public string FileColorString
        {
            get { return _FileColorString; }
            set
            {
                _FileColorString = value;
                OnPropertyChanged("FileColorString");
            }
        }

        public bool FileSizeSeriesVisibility
        {
            get { return _FileSizeSeriesVisibility; }
            set
            {
                _FileSizeSeriesVisibility = value;
                OnPropertyChanged("FileSizeSeriesVisibility");
            }
        }

        public bool WriteSizeSeriesVisibility
        {
            get { return _WriteSizeSeriesVisibility; }
            set
            {
                _WriteSizeSeriesVisibility = value;
                OnPropertyChanged("WriteSizeSeriesVisibility");
            }
        }

        public bool TransferredVisibility
        {
            get { return _TransferredVisibility; }
            set
            {
                _TransferredVisibility = value;
                OnPropertyChanged("TransferredVisibility");
            }
        }

        public bool AllVisibility
        {
            get { return _AllVisibility; }
            set
            {
                _AllVisibility = value;
                OnPropertyChanged("AllVisibility");
            }
        }

        public bool LegendVisibility
        {
            get { return _LegendVisibility; }
            set
            {
                _LegendVisibility = value;
                OnPropertyChanged("LegendVisibility");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void File_Color_Click(object sender, RoutedEventArgs e)
        {
            if (ColorToggle)
            {
                FileColorString = "#8bcdfc";
                _ColorToggle = false;
            }
            else
            {
                FileColorString = "#ccdfff";
                _ColorToggle = true;
            }
        }

        private void AllVisibility_Converter(object sender, RoutedEventArgs e)
        {
            if (_AllVisibility)
            {
                FileSizeSeriesVisibility = true;
                WriteSizeSeriesVisibility = true;
                TransferredVisibility = true;
            }
            else
            {
                FileSizeSeriesVisibility = false;
                WriteSizeSeriesVisibility = false;
                TransferredVisibility = false;
            }
        }
        private void Data_Add_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            File_Size_Values.Add(new ObservableValue(rand.Next(1,2000)));
            Write_Size_Values.Add(new ObservableValue(rand.Next(1,2000)));
            Transferred_Values.Add(new ObservableValue(rand.Next(1,2000)));
        }
    }
}
