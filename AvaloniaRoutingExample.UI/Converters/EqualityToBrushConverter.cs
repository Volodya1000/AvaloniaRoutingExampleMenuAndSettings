using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AvaloniaRoutingExample.UI.Converters;

public class EqualityToBrushConverter : IMultiValueConverter
{
    public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (values.Count < 2)
            return Brushes.Transparent;

        var currentSection = values[0];
        var thisItem = values[1];

        return Equals(currentSection, thisItem)
            ? new SolidColorBrush(Colors.LightBlue)
            : Brushes.Transparent;
    }

    public object[] ConvertBack(object? value, Type[] targetTypes, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
