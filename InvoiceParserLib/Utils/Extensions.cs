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
        //public static object? ParseStringRecordToObject(this string record)
        //{
        //    try 
        //    { 
        //        string[] fields = record.Split(pipeSeparator);
        //        if (GlobalValidations<string>.HasElements(fields))
        //        {
        //            string recordType = fields[0];
        //            if (recordType.IsValidRecordType())
        //            {
        //                string recordTypeModel = recordType.GetModelByRecordType();
        //                Type modelObjectType = GetObjectModelType(recordTypeModel);
        //                object? modelObject;
        //                if (modelObjectType == typeof(object))
        //                    modelObject = null;
        //                else
        //                    modelObject = modelObjectType.GetConstructor([typeof(string)]).Invoke([record]);
        //                return modelObject;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log(ex.Message);
        //    }

        //    return null;
        //}

        //public static Type GetObjectModelType(string modelName)
        //{
        //    string _modelName = modelName.Replace(" ", string.Empty);
        //    string customTypeName = $"{ModelsNameSpace}{(dic_TiposRegistro.ContainsValue(modelName)? ".RecordEntities" : string.Empty)}.{_modelName}";
        //    return Type.GetType(customTypeName) is null ? typeof(object) : Type.GetType(customTypeName);
        //}
        //#region GetValues
        //public static string GetStringAtPosition(this ICollection<string> fields, int position)
        //{
        //    return GlobalValidations<string>.ExistsInCollection(fields, position)? fields.ToList()[position] : string.Empty;
        //}
        //public static double GetDoubleAtPosition(this ICollection<string> fields, int position)
        //{
        //    if (GlobalValidations<string>.ExistsInCollection(fields, position)) {
        //        double.TryParse(fields.ToList()[position], out double value);
        //        return value;
        //    }
        //    return 0.0f;
        //}
        //public static long GetLongAtPosition(this ICollection<string> fields, int position)
        //{
        //    if (GlobalValidations<string>.ExistsInCollection(fields, position))
        //    {
        //        long.TryParse(fields.ToList()[position], out long value);
        //        return value;
        //    }
        //    return 0;
        //}
        //public static int GetIntAtPosition(this ICollection<string> fields, int position)
        //{
        //    if (GlobalValidations<string>.ExistsInCollection(fields, position))
        //    {
        //        int.TryParse(fields.ToList()[position], out int value);
        //        return value;
        //    }
        //    return 0;
        //}
        //public static DateTime? GetDateAtPosition(this ICollection<string> fields, int position)
        //{
        //    if (!GlobalValidations<string>.ExistsInCollection(fields, position))
        //        return null;
        //    if (DateTime.TryParseExact(fields.ToList()[position], InvoiceFileDateFormat, new CultureInfo(UsEnglishCulture), DateTimeStyles.None, out DateTime value))
        //        return value;
        //    return null;
        //}
        //#endregion
    }
}
