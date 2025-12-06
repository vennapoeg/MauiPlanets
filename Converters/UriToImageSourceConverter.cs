using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace MauiPlanets.Converters
{
    public class UriToImageSourceConverter : IValueConverter
    {
        // Convert string URL to ImageSource
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string url && !string.IsNullOrWhiteSpace(url))
            {
                return ImageSource.FromUri(new Uri(url));
            }

            return null;
        }

        // ConvertBack is not implemented
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}

