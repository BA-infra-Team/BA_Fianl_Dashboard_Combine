using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace BA_Dashboard
{
    /// <summary>
    /// Chart7_2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Chart7_2 : UserControl
    {
        public int testsc_Num = 4;
        public Chart7_2()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "testsc_1",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc1_Count) },
                    DataLabels = true,
                    Fill= new SolidColorBrush(Color.FromArgb(255, (byte)0, (byte)154, (byte)49)),
                },
                new PieSeries
                {
                    Title = "testsc_2",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc2_Count) },
                    DataLabels = true,
                    Fill= new SolidColorBrush(Color.FromArgb(255, (byte)198, (byte)231, (byte)206)),
                },
                new PieSeries
                {
                    Title = "testsc_3",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc3_Count) },
                    DataLabels = true,
                    Fill= new SolidColorBrush(Color.FromArgb(255, (byte)132, (byte)207, (byte)150)),
                },
                new PieSeries
                {
                    Title = "testsc_4",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Schedule_testsc4_Count) },
                    DataLabels = true,
                    Fill= new SolidColorBrush(Color.FromArgb(255, (byte)67, (byte)145, (byte)155)),
                },
            };

            DataContext = this;
        }


        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        private void DataAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            testsc_Num++;
            string title = string.Format("testsc_{0}", testsc_Num);
            Random random_value = new Random();
            this.SeriesCollection.Add(new PieSeries
            {
                Title = title,
                Values = new ChartValues<ObservableValue> { new ObservableValue(random_value.Next(50, 400)) },
                DataLabels = true,
                Fill = new SolidColorBrush(Color.FromArgb(255, (byte)random_value.Next(1, 255), (byte)random_value.Next(1, 255), (byte)random_value.Next(1, 255)))
            });
        }

        private void DataRemove_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (testsc_Num > 4)
            {
                testsc_Num--;
                this.SeriesCollection.RemoveAt(SeriesCollection.Count - 1);
            }
            
        }
    }
}

