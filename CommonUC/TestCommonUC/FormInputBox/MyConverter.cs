using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Data;

namespace TestCommonUC.FormInputBox
{
    public class MyConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null||parameter==null)
            {
                return "";
            }
            PropertyInfo pi= typeof(Class1).GetProperty(parameter.ToString());

            object[] attributeArr = pi.GetCustomAttributes(typeof(ClassAttribute),true);
            if (attributeArr.Length > 0)
            {
                ClassAttribute ca = attributeArr[0] as ClassAttribute;
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
