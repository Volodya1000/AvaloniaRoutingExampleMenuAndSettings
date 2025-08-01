using Avalonia.Data.Converters;
using System;
using System.Globalization;

namespace AvaloniaRoutingExample.UI.Converters;

public class BoolToClassNameConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool b && b)
            return "selected";
        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => throw new NotSupportedException();
}
