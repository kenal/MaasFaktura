using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Desktop.HelperClass
{
    public class BackgroundConverter2: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //return value != null && (int)value == 1 ;
            if (value != null)
            {
                var intValue = System.Convert.ToInt32(value);
                if (intValue == 1)
                    return "Urlaub";
                else if (intValue == 2)
                    return "Abwesend";
                else 
                    return "Krank";
            }
            else
                return Brushes.White;


        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
