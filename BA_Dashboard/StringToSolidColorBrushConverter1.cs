using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace BA_Dashboard
{
    public class StringToSolidColorBrushConverter1 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // solid brush의 string 값 가져오기 
            string ColorString = (string)value;
            // string brush 값에 해당하는 SolidBrush 가져오기 
            Color color = (Color)ColorConverter.ConvertFromString(ColorString);
            SolidColorBrush brush = new SolidColorBrush(color) { Opacity = 0.15 };
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
