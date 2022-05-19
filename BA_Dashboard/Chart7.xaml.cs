using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.ComponentModel;


namespace BA_Dashboard
{
    /// <summary>
    /// Chart7.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart7 : UserControl, INotifyPropertyChanged
    {
        public int testsc_Num = 4;

        private double _Font_Size;
        private bool _LegendVisibility;

        private SolidColorBrush _Testsc_1_Color;
        private SolidColorBrush _Testsc_2_Color;
        private SolidColorBrush _Testsc_3_Color;
        private SolidColorBrush _Testsc_4_Color;

        public Chart7()
        {
            InitializeComponent();

            Font_Size = 40;

            //fontsize = (double)Form1.Instance.Width / 300; 
            //Form1.Instance.Height;

            Testsc_1_Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc1_Count) };
            Testsc_2_Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc2_Count) };
            Testsc_3_Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc3_Count) };
            Testsc_4_Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc4_Count) };

            Testsc_1_Color = new SolidColorBrush(Color.FromArgb(255, (byte)0, (byte)154, (byte)49));
            Testsc_2_Color = new SolidColorBrush(Color.FromArgb(255, (byte)198, (byte)231, (byte)206));
            Testsc_3_Color = new SolidColorBrush(Color.FromArgb(255, (byte)132, (byte)207, (byte)150));
            Testsc_4_Color = new SolidColorBrush(Color.FromArgb(255, (byte)67, (byte)145, (byte)155));

            DataContext = this;
        }


        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
        public ChartValues<ObservableValue> Testsc_1_Values { get; set; }
        public ChartValues<ObservableValue> Testsc_2_Values { get; set; }
        public ChartValues<ObservableValue> Testsc_3_Values { get; set; }
        public ChartValues<ObservableValue> Testsc_4_Values { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public double Font_Size
        {
            get { return _Font_Size; }
            set
            {
                _Font_Size = value;
                OnPropertyChanged("Font_Size");
            }
        }

        public SolidColorBrush Testsc_1_Color
        {
            get { return _Testsc_1_Color; }
            set
            {
                _Testsc_1_Color = value;
                OnPropertyChanged("Testsc_1_Color");
            }
        }

        public SolidColorBrush Testsc_2_Color
        {
            get { return _Testsc_2_Color; }
            set
            {
                _Testsc_2_Color = value;
                OnPropertyChanged("Testsc_2_Color");
            }
        }

        public SolidColorBrush Testsc_3_Color
        {
            get { return _Testsc_3_Color; }
            set
            {
                _Testsc_3_Color = value;
                OnPropertyChanged("Testsc_3_Color");
            }
        }

        public SolidColorBrush Testsc_4_Color
        {
            get { return _Testsc_4_Color; }
            set
            {
                _Testsc_4_Color = value;
                OnPropertyChanged("Testsc_4_Color");
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

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //this.Width
            int width = Form1.Instance.Size.Width;
            int height = Form1.Instance.Size.Height;

            if (width < 900 && height < 900)
            {
                Font_Size = 10;
            }
            else
            {
                Font_Size = 40;
            }
        }
    }
}
