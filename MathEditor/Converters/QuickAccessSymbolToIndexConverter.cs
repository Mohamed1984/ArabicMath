namespace MathEditor.Converters
{
    using System;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;
    public class QuickAccessSymbolToIndexConverter : IValueConverter
    {
        // Methods
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int num = 0;
            
            MathEditor.ViewModel.EditorViewModel model=(MathEditor.ViewModel.EditorViewModel)
                App.Current.FindResource("viewModel");
            if (value.GetType() == typeof(char))
            {
                num = model.QuickAccessChars.IndexOf((char)value) + 1;
            }
            return num;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            char ch = '?';
            //if ((value.GetType() == typeof(int)) && (((int)value) < model.QuickAccessChars.Count))
            //{
           //     //ch = model.QuickAccessChars[(int)value];
            //}
            return ch;
        }
    }


}

