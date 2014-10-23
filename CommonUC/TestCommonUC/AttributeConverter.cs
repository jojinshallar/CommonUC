using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Data;

namespace TestCommonUC
{
    public class AttributeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return "";
            }
            object[] attributeArr = (value as Type).GetCustomAttributes(typeof(WindowClassAttribute),true);
            if (attributeArr.Length > 0)
            {
                WindowClassAttribute ca = attributeArr[0] as WindowClassAttribute;
                return ca.Name;
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
