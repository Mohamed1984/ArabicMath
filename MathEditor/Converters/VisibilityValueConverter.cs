namespace MathEditor.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;

    public class VisibilityValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(Visibility))
            {
                throw new NotImplementedException();
            }
            bool? nullable = (bool?) value;
            bool flag = false;
            if ((parameter != null) && "true".Equals(parameter))
            {
                flag = true;
            }
            bool? nullable2 = nullable;
            bool flag2 = !flag;
            if ((nullable2.GetValueOrDefault() == flag2) && nullable2.HasValue)
            {
                return (Visibility) 0;
            }
            return (Visibility) 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? nullable = true;
            if (targetType != typeof(bool?))
            {
                throw new NotImplementedException();
            }
            if (((Visibility?) value) == null)
            {
                nullable = true;
            }
            else
            {
                nullable = false;
            }
            bool flag = false;
            if ((parameter != null) && "true".Equals(parameter))
            {
                flag = true;
            }
            bool? nullable2 = nullable;
            bool flag2 = flag;
            return (nullable2.HasValue ? new bool?(nullable2.GetValueOrDefault() ^ flag2) : null);
        }
    }
}

