using System.Globalization;

namespace Notes.Utilities

{
    public class FloatToIntConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (!float.TryParse(parameter as string, out float multiplier))
                multiplier = 1;

            return (int)Math.Round(multiplier * (float)value);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (!float.TryParse(parameter as string, out float divider))
                divider = 1;

            return ((float)(int)value) / divider;
        }
    }
}
