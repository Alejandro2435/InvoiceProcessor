using System.Reflection;
using System.Text;
using static InvoiceParser.Utils.ConstVariables;
using static InvoiceParser.Utils.Enums;

namespace InvoiceParser.Utils
{
    public static class Globals
    {
        public static void SetValuesToProperties(object model, string record, Dictionary<string, int> modelProperties)
        {
            try 
            {   
                ICollection<string> fields = record.Split(pipeSeparator).ToList();
                List<PropertyInfo> properties = model.GetType().GetProperties().ToList();
                properties.ForEach(property =>
                {
                    if (modelProperties.ContainsKey(property.Name))
                    {
                        Type propertyType = property.PropertyType;
                        if (propertyType.In(typeof(Int32), typeof(Int64)))
                        {
                            if (propertyType == typeof(Int32))
                                property.SetValue(model, fields.GetIntAtPosition(modelProperties[property.Name]));
                            else
                                property.SetValue(model, fields.GetLongAtPosition(modelProperties[property.Name]));
                        }
                        else if (propertyType == typeof(Double))
                        {
                            property.SetValue(model, fields.GetDoubleAtPosition(modelProperties[property.Name]));
                        }
                        else
                        {
                            property.SetValue(model, fields.GetStringAtPosition(modelProperties[property.Name]));
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        public static void Log(string logMessage)
        {
            string logPath = $"{Directory.GetCurrentDirectory()}/Log_{DateTime.Now:dd-MM-yyyy}.txt";
            StringBuilder logContent = new StringBuilder();
            logContent.Append($"{new string('-', 20)} {DateTime.Now:dd-MM-yyyy HH:mm:ss tt} {new string('-', 20)}\n");
            logContent.Append($"{logMessage}\n");
            File.AppendAllText(logPath, logContent.ToString());
        }

        public static int GetRecordFieldsNumber(string record) => record.Split(pipeSeparator).Length - 1;

        public static Type GetObjectModelType(string modelName)
        {
            string _modelName = modelName.Replace(" ", string.Empty);
            string customTypeName = $"{ModelsNameSpace}{(dic_TiposRegistro.ContainsValue(modelName) ? ".RecordEntities" : string.Empty)}.{_modelName}";
            return Type.GetType(customTypeName) is null ? typeof(object) : Type.GetType(customTypeName);
        }
    }
}
