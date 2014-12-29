using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Desktop.HelperClass
{
    public class BackgroundConverterPoruke: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ImageSource result = null;
            if((bool)value == false)
            {
                result = new BitmapImage(new Uri("ikone/star-empty.png", UriKind.Relative));
            }
            else
            {
                result = new BitmapImage(new Uri("ikone/star.png", UriKind.Relative));
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
