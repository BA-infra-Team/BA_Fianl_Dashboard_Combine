using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using LiveCharts.Wpf;

namespace BA_Dashboard
{
    public class DropDownViewModel : INotifyPropertyChanged
    {
        private SeriesCollection _series;

        public DropDownViewModel()
        {
            double[] numbers = new double[] { ChartData.Total_Error_Ratio_PieChart_Total_Completed_Count, ChartData.Total_Error_Ratio_PieChart_Total_Error_Count };
            var navigation = new List<SeriesCollection>();
            //var initialValues = DataProvider.Values.ToArray();
            var initialValues = numbers;

            Series = GroupSeriesByTheshold(content: initialValues, threshold: initialValues.Max() * .2);

            SliceClickCommand = new DropDownCommand(dropDownPoint =>
            {
                //if the point has no content to display...
                if (dropDownPoint.Content.Length == 1) return;

                navigation.Add(Series.Select(x => new PieSeries
                {
                    Values = x.Values,
                    Title = x.Title,
                    Fill = ((Series)x).Fill
                }).AsSeriesCollection());

                navigation.Add(Series.Select(x => new PieSeries
                {
                    Title = "Canceled",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Canceled_Error_Count) },
                    DataLabels = true,
                    Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#143F6B"))
                }).AsSeriesCollection());

                navigation.Add(Series.Select(x => new PieSeries
                {
                    Title = "Failed",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Failed_Error_Count) },
                    DataLabels = true,
                    Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F55353"))
                }).AsSeriesCollection());

                navigation.Add(Series.Select(x => new PieSeries
                {
                    Title = "Partially Completed",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Partially_Completed_Count) },
                    DataLabels = true,
                    Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#82C0FA"))
                }).AsSeriesCollection());

                navigation.Add(Series.Select(x => new PieSeries
                {
                    Title = "Suspend",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(ChartData.Error_Ratio_By_Job_Status_PieChart_Suspended_Error_Count) },
                    DataLabels = true,
                    Fill = (SolidColorBrush)(new BrushConverter().ConvertFrom("#8A6EFA"))
                }).AsSeriesCollection());



                Series = GroupSeriesByTheshold(content: dropDownPoint.Content, threshold: dropDownPoint.Content.Max() * .2);
            });

            GoBackCommand = new RelayCommand(() =>
            {
                if (!navigation.Any()) return;
                var previous = navigation.Last();
                if (previous == null) return;
                Series = previous;
                navigation.Remove(previous);
            });

            Formatter = x => x.ToString("N1");
        }

        public SeriesCollection Series
        {
            get { return _series; }
            set
            {
                _series = value;
                OnPropertyChanged("Series");
            }
        }
        public DropDownCommand SliceClickCommand { get; set; }
        public RelayCommand GoBackCommand { get; set; }
        public Func<double, string> Formatter { get; set; }

        private static SeriesCollection GroupSeriesByTheshold(double[] content, double threshold)
        {
            var series = content
                .Where(x => x > threshold)
                .Select((value, index) => new PieSeries
                {
                    Values = new ChartValues<DropDownPoint>
                    {
                        new DropDownPoint {Content = new[] {value}}
                    },
                    Title = "Series " + index
                }).AsSeriesCollection();

            var thresholdSeries = new PieSeries
            {
                Values = new ChartValues<DropDownPoint>
                {
                    new DropDownPoint
                    {
                        Content = content.Where(x => x < threshold).ToArray()
                    }
                },
                Title = "DropDown Slice",
                Fill = new SolidColorBrush(Color.FromRgb(30, 30, 30)),
                PushOut = 5
            };
            series.Add(thresholdSeries);

            return series;
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
