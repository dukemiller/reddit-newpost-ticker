using System;
using System.Globalization;
using System.Web;
using System.Windows.Data;

namespace reddit_newpost_ticker.Classes
{
    public class HtmlDecodeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return HttpUtility.HtmlDecode(System.Convert.ToString(value));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class RedditConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToString(value).ToLower().Contains("reddit");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}