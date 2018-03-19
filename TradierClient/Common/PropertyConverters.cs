namespace TradierClient
{
    using System;
    using System.Globalization;

    public class PropertyConverters
    {
        public static bool ParseBool(string input)
        {
            return input.ToUpper() == "TRUE";
        }

        public static int? ParseInt(string input)
        {
            int output;

            if (int.TryParse(input, out output))
                return output;
            else
                return null;
        }

        public static decimal? ParseDecimal(string input)
        {
            decimal output;

            if (decimal.TryParse(input, out output))
                return output;
            else
                return null;
        }

        public static double? ParseDouble(string input)
        {
            double output;

            if (double.TryParse(input, out output))
                return output;
            else
                return null;
        }

        public static DateTime ParseDateTime(string input, string format)
        {
            return DateTime.ParseExact(input,
                    format,
                    CultureInfo.InvariantCulture);
        }

        public static DateTime? ParseUnixTime(string input)
        {
            double? ms = PropertyConverters.ParseDouble(input);

            if (ms == null)
                return null;

            return new DateTime(1970, 1, 1, 0, 0, 0).
                AddMilliseconds((double)ms); 
        }
    }
}
