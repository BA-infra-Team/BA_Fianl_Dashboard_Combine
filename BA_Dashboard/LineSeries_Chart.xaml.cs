using System;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using System.ComponentModel;
using LiveCharts.Defaults;
using System.Collections.Generic;

namespace BA_Dashboard
{
    /// <summary> 
    /// LineSeries_Chart.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LineSeries_Chart : UserControl, INotifyPropertyChanged
    {
        #region private 변수
        private bool _FileColorToggle;
        private bool _WriteColorToggle;
        private bool _TransColorToggle;
        private bool _DataToggle;

        private string _FileColorString;
        private string _WriteColorString;
        private string _TransColorString;

        private bool _LegendVisibility;
        private bool _FileSizeSeriesVisibility;
        private bool _WriteSizeSeriesVisibility;
        private bool _TransferredVisibility;
        private bool _AllVisibility;
        #endregion

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
        #region 생성자
        public LineSeries_Chart()
        {
            InitializeComponent();

            FileColorToggle = false;
            WriteColorToggle = false;
            TransColorToggle = false;
            DataToggle = false;

            LegendVisibility = true;
            AllVisibility = true;
            FileSizeSeriesVisibility = true;
            WriteSizeSeriesVisibility = true;
            TransferredVisibility = true;

            FileColorString = "#FF0000FF";
            WriteColorString = "#FFFF0000";
            TransColorString = "#FFFFFF00";


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
            DateTimeFormatter = value => new DateTime((long)value).ToString("yy:mm:dd");
            Labels = new[] { "22-02-08", "22-02-09", "22-02-10", "22-02-11", "22-02-12", "22-02-13", "22-02-14", "22-02-15" };
            DataContext = this;
        }
        #endregion
        #region public 변수
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public Func<double, string> DateTimeFormatter { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ChartValues<ObservableValue> File_Size_Values { get; set; }
        public ChartValues<ObservableValue> Write_Size_Values { get; set; }
        public ChartValues<ObservableValue> Transferred_Values { get; set; }

        public List<string> LabelValues { get; set; }

        public bool FileColorToggle
        {
            get { return _FileColorToggle; }
            set
            {
                _FileColorToggle = value;
                OnPropertyChanged("FileColorToggle");
            }
        }

        public bool WriteColorToggle
        {
            get { return _WriteColorToggle; }
            set
            {
                _WriteColorToggle = value;
                OnPropertyChanged("WriteColorToggle");
            }
        }

        public bool TransColorToggle
        {
            get { return _TransColorToggle; }
            set
            {
                _TransColorToggle = value;
                OnPropertyChanged("TransColorToggle");
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

        public string WriteColorString
        {
            get { return _WriteColorString; }
            set
            {
                _WriteColorString = value;
                OnPropertyChanged("WriteColorString");
            }
        }

        public string TransColorString
        {
            get { return _TransColorString; }
            set
            {
                _TransColorString = value;
                OnPropertyChanged("TransColorString");
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
        #endregion
        #region 이벤트함수
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void File_Color_Click(object sender, RoutedEventArgs e)
        {
            if (FileColorToggle)
            {
                FileColorString = "#00DEFF";
                _FileColorToggle = false;
            }
            else
            {
                FileColorString = "#FF0000FF";
                _FileColorToggle = true;
            }
        }

        private void Write_Color_Click(object sender, RoutedEventArgs e)
        {
            if (WriteColorToggle)
            {
                WriteColorString = "#FF8900";
                _WriteColorToggle = false;
            }
            else
            {
                WriteColorString = "#FFFF0000";
                _WriteColorToggle = true;
            }
        }

        private void Trans_Color_Click(object sender, RoutedEventArgs e)
        {
            if (TransColorToggle)
            {
                TransColorString = "#9AFF00";
                _TransColorToggle = false;
            }
            else
            {
                TransColorString = "#FFFFFF00";
                _TransColorToggle = true;
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

        private void Data_Remove_Click(object sender, RoutedEventArgs e)
        {
            if (File_Size_Values.Count >8)
            {
                File_Size_Values.RemoveAt(File_Size_Values.Count - 1);
                Write_Size_Values.RemoveAt(File_Size_Values.Count - 1);
                Transferred_Values.RemoveAt(File_Size_Values.Count - 1);
            }
        }
        #endregion
    }
}
