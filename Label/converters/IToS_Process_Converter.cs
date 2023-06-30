using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Label.converters
{
    internal class IToS_Process_Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string res = null;
            int num = -1;
            if (value != null && int.TryParse(value.ToString(),out num))
            {
                if (num >= 0 && num <= 100) res = "完成度 " + num.ToString() + "%";
            }
            return res;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
