using System;
using System.Globalization;
using Xamarin.Forms;

namespace TourUI.Converts
{
    public class RatingConvert : IValueConverter
    {
        public RatingConvert()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var param = value as string;
            var number = param.ToString(CultureInfo.InvariantCulture);
            if (number == "0")
                number = "0.0";
            if (!number.Contains("."))
                number = number + ".0";
            return number;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
