using InvoiceProcessor.Models.Entities;
using System.Reflection;
using System.Text;

namespace InvoiceProcessor.Utils
{
    public static class Globals
    {
        public static void AssignPropertyValue(object entity, List<Field> fields)
        {
            try{
                List<PropertyInfo> properties = [.. entity.GetType().GetProperties().Where(property => {
                    Type propType = property.PropertyType;
                    bool isBaseType = propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Field<>);
                    return (propType.Equals(typeof(Field)) || isBaseType) && property.CanWrite;
                })];
                properties.ForEach(property =>
                {
                    Field? f = fields.Where(field => field.Index == (property.GetValue(entity) as Field)?.Index).FirstOrDefault();
                    if (f.NotNull())
                    {
                        property.SetValue(entity, f);
                    }
                }); 
            }
            catch(Exception ex)
            {
                Log(ex.Message);
            }
        }

        public static void Log(string logMessage)
        {
            try{
                string logDirectory = $"{Directory.GetCurrentDirectory()}/Log_{DateTime.Now:dd-MM-yyyy}";
                string logPath = $"{logDirectory}/{Environment.CurrentManagedThreadId}.txt";
                StringBuilder logContent = new();
                logContent.Append($"{new string('-', 20)} {DateTime.Now:dd-MM-yyyy HH:mm:ss tt} {new string('-', 20)}\n");
                logContent.Append($"{logMessage}\n");
                if (!Directory.Exists(logDirectory)) { Directory.CreateDirectory(logDirectory); }
                if (!File.Exists(logPath)) { File.Create(logPath); }
                File.AppendAllText(logPath, logContent.ToString());
            }
            catch (Exception) { }
        }
    }
}
