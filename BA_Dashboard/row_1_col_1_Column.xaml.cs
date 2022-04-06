using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using LiveCharts;
using LiveCharts.Defaults;

namespace BA_Dashboard
{
    /// <summary>
    /// row_1_col_1_Column.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class row_1_col_1_Column : UserControl, INotifyPropertyChanged
    {
        private bool _FileSizeSeriesVisibility;
        private bool _WriteSizeSeriesVisibility;
        private bool _TransferredVisibility;

        public row_1_col_1_Column()
        {
            InitializeComponent();
            FileSizeSeriesVisibility = true;
            WriteSizeSeriesVisibility = true;
            TransferredVisibility = true;

            File_Size_Values = new ChartValues<ObservableValue>
            {
                new ObservableValue(ChartData.Total_File_Size_LineChart_2022_02_08_Count),
                new ObservableValue(ChartData.Total_File_Size_LineChart_2022_02_09_Count),
                new ObservableValue(ChartData.Total_File_Size_LineChart_2022_02_10_Count),
                new ObservableValue(ChartData.Total_File_Size_LineChart_2022_02_11_Count),
                new ObservableValue(ChartData.Total_File_Size_LineChart_2022_02_12_Count),
                new ObservableValue(ChartData.Total_File_Size_LineChart_2022_02_13_Count),
                new ObservableValue(ChartData.Total_File_Size_LineChart_2022_02_14_Count),
                new ObservableValue(ChartData.Total_File_Size_LineChart_2022_02_15_Count),
            };

            Write_Size_Values = new ChartValues<ObservableValue>
            {
                new ObservableValue(ChartData.Total_Write_Size_LineChart_2022_02_08_Count),
                new ObservableValue(ChartData.Total_Write_Size_LineChart_2022_02_09_Count),
                new ObservableValue(ChartData.Total_Write_Size_LineChart_2022_02_10_Count),
                new ObservableValue(ChartData.Total_Write_Size_LineChart_2022_02_11_Count),
                new ObservableValue(ChartData.Total_Write_Size_LineChart_2022_02_12_Count),
                new ObservableValue(ChartData.Total_Write_Size_LineChart_2022_02_13_Count),
                new ObservableValue(ChartData.Total_Write_Size_LineChart_2022_02_14_Count),
                new ObservableValue(ChartData.Total_Write_Size_LineChart_2022_02_15_Count),
            };

            Transferred_Values = new ChartValues<ObservableValue>
            {
                new ObservableValue(ChartData.Total_Data_Transferred_LineChart_2022_02_08_Count),
                new ObservableValue(ChartData.Total_Data_Transferred_LineChart_2022_02_09_Count),
                new ObservableValue(ChartData.Total_Data_Transferred_LineChart_2022_02_10_Count),
                new ObservableValue(ChartData.Total_Data_Transferred_LineChart_2022_02_11_Count),
                new ObservableValue(ChartData.Total_Data_Transferred_LineChart_2022_02_12_Count),
                new ObservableValue(ChartData.Total_Data_Transferred_LineChart_2022_02_13_Count),
                new ObservableValue(ChartData.Total_Data_Transferred_LineChart_2022_02_14_Count),
                new ObservableValue(ChartData.Total_Data_Transferred_LineChart_2022_02_15_Count),
            };

            DataContext = this;
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

        public event PropertyChangedEventHandler PropertyChanged;
        public ChartValues<ObservableValue> File_Size_Values { get; set; }
        public ChartValues<ObservableValue> Write_Size_Values { get; set; }
        public ChartValues<ObservableValue> Transferred_Values { get; set; }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Form1.Instance.row_1_col_1_panel.Controls.ContainsKey("row_1_col_1_Line_UC"))
            {
                row_1_col_1_Line_UC UChome = new row_1_col_1_Line_UC();
                UChome.Dock = System.Windows.Forms.DockStyle.Fill;
                Form1.Instance.row_1_col_1_panel.Controls.Add(UChome);
            }
            Form1.Instance.row_1_col_1_panel.Controls["row_1_col_1_Line_UC"].BringToFront();
        }
    }
}
