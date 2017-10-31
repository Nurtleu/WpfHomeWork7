using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHomeWork7
{
    public class Convertor:IMultivalueConvertor
    {
        private DateTime dataTime;

        public object Convert(object[] values, Type targetType, object parameter)
        {
            throw new NotImplementedException();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter)
        {
            dataTime = (DateTime)value;
            return new object[] { dataTime.Day, dataTime.Month, dataTime.Year };
        }
    }
}
