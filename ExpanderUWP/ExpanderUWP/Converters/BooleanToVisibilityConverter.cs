using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ExpanderUWP.Converters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (targetType == typeof(Visibility))
            {
                var isVisible = (bool)value;
                var param = parameter != null ? parameter.ToString() : string.Empty;

                if (param == "!")
                {
                    isVisible = !isVisible;
                }

                var visibility = isVisible ? Visibility.Visible : Visibility.Collapsed;

                return visibility;
            }
            // else
            throw new InvalidOperationException("Converter can only be applied to a property of type Visibility.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
