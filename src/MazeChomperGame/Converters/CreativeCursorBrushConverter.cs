using Avalonia.Data.Converters;
using Avalonia.Media;
using MazeChomperGame.Models.Creative;
using System;
using System.Globalization;

namespace MazeChomperGame.Converters;

public class CreativeCursorBrushConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value is bool isCursor && isCursor
            ? new SolidColorBrush(Color.Parse("#FFD700"))
            : new SolidColorBrush(Color.Parse("#333333"));
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
