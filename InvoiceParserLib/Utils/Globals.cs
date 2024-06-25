using InvoiceParserLib.Models.Entities;
using System.Reflection;
using System.Text;

namespace InvoiceParserLib.Utils
{
    public static class Globals
    {
        public static void AssignPropertyValue(object entity, List<Field> fields)
        {
            List<PropertyInfo> properties = [.. entity.GetType().GetProperties().Where(property => {
                var propertyType = property.PropertyType;
                return propertyType.Equals(typeof(Field)) || propertyType.IsSubclassOf(typeof(Field));
            })];
            properties.ForEach(property =>
            {
                Field? _field = property.GetValue(property) as Field;
                if(_field.NotNull()){
                    Field? f = fields.Select(field => field.Index == _field?.Index) as Field;
                    if(f.NotNull()) { 
                        f.Value = _field.Value; 
                    }
                }
            });
        }
        public static void SetValuesToProperties(object model, ICollection<Field> fields, Dictionary<string, int> modelProperties)
        {
            try 
            {   
                List<PropertyInfo> properties = [.. model.GetType().GetProperties()];
                properties.ForEach(property =>
                {
                    if (modelProperties.TryGetValue(property.Name, out int value))
                    {
                        Field _property = (Field)fields.Select(field => field.Index == value);
                        //Type propertyType = property.PropertyType;
                        property.SetValue(model, _property.Value);
                        //if (propertyType.In(typeof(Int32), typeof(Int64)))
                        //{
                        //    if (propertyType == typeof(Int32))
                        //        property.SetValue(model, fields.GetIntAtPosition(modelProperties[property.Name]));
                        //    else
                        //        property.SetValue(model, fields.GetLongAtPosition(modelProperties[property.Name]));
                        //}
                        //else if (propertyType == typeof(Double))
                        //{
                        //    property.SetValue(model, fields.GetDoubleAtPosition(modelProperties[property.Name]));
                        //}
                        //else
                        //{
                        //    property.SetValue(model, fields.GetStringAtPosition(modelProperties[property.Name]));
                        //}
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

        //public static int GetRecordFieldsNumber(string record) => record.Split(pipeSeparator).Length - 1;

        //public static Type GetObjectModelType(string modelName)
        //{
        //    string _modelName = modelName.Replace(" ", string.Empty);
        //    string customTypeName = $"{ModelsNameSpace}{(dic_TiposRegistro.ContainsValue(modelName) ? ".RecordEntities" : string.Empty)}.{_modelName}";
        //    return Type.GetType(customTypeName) is null ? typeof(object) : Type.GetType(customTypeName);
        //}
    }
}
