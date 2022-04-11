using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;
using System.Windows.Media;


namespace BA_Dashboard
{
    /// <summary>
    /// Chart7.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart7 : UserControl
    {
        public Chart7()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Testsc_1",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc1_Count) },
                    DataLabels = true,
                    Fill= new SolidColorBrush(Color.FromArgb(255, (byte)0, (byte)154, (byte)49))
        },
                new PieSeries
                {
                    Title = "Testsc_2",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc2_Count) },
                    DataLabels = true,
                    Fill= new SolidColorBrush(Color.FromArgb(255, (byte)198, (byte)231, (byte)206))

                },
                new PieSeries
                {
                    Title = "Testsc_3",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc3_Count) },
                    DataLabels = true,
                    Fill= new SolidColorBrush(Color.FromArgb(255, (byte)132, (byte)207, (byte)150))
                },
                new PieSeries
                {
                    Title = "Testsc_4",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc4_Count) },
                    DataLabels = true,
                    Fill= new SolidColorBrush(Color.FromArgb(255, (byte)67, (byte)145, (byte)155))
                },                
            };

            DataContext = this;
        }


        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
    }
}
