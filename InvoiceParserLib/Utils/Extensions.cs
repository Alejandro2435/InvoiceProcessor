using System.Collections;
using static InvoiceParserLib.Utils.Globals; 

namespace InvoiceParserLib.Utils
{
    public static class Extensions
    {
        public static bool In<T>(this T item, params T[] range) => range.Cast<T>().Contains(item);

        public static bool Between<T>(this T item, T minvalue, T maxvalue)
        {

            try
            {
                if (item.IsNumeric() && minvalue.IsNumeric() && maxvalue.IsNumeric())
                {
                    return Convert.ToDouble(item) >= Convert.ToDouble(minvalue) && Convert.ToDouble(item) <= Convert.ToDouble(maxvalue);
                }
                else if (item.GetType().Equals(typeof(TimeSpan)) && minvalue.GetType().Equals(typeof(TimeSpan)) && maxvalue.GetType().Equals(typeof(TimeSpan)))
                {
                    return TimeSpan.Parse(item.ToString()) >= TimeSpan.Parse(minvalue.ToString()) && TimeSpan.Parse(item.ToString()) <= TimeSpan.Parse(maxvalue.ToString());
                }
                else if (item.IsDateTime() && minvalue.IsDateTime() && maxvalue.IsDateTime())
                {
                    return Convert.ToDateTime(item) >= Convert.ToDateTime(minvalue) && Convert.ToDateTime(item) <= Convert.ToDateTime(maxvalue);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
                return false;
            }
        }
        public static bool NotNull<T>(this T attr) => attr != null;
        ///<summary>
        /// Funcion que valida si un objeto es del tipo numerico o se puede convertir a numero
        ///</summary>
        public static bool IsNumeric<T>(this T item) => decimal.TryParse(item?.ToString(), out _);
        ///<summary>
        /// Funcion que valida si un objeto es del tipo de dato DateTime o se puede convertir a DateTime
        ///</summary>
        public static bool IsDateTime<T>(this T item) => DateTime.TryParse(item?.ToString(), out _);

        public static string CastDoubleToStringFormat(this double _value) => $"{_value}{(_value % 1 == 0 ? ".000" : string.Empty)}";

        public static bool HasElements(this ICollection collection) => collection.Count > 0;
    }
}
