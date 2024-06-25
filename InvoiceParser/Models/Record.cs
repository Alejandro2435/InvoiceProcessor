using InvoiceParser.CustomValidations;
using InvoiceParser.Models.Interfaces;
using InvoiceParser.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InvoiceParser.Utils.Globals;

namespace InvoiceParser.Models
{
    public class Record : IInvoiceRecord
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public List<Field> Fields { get; set; } = [];
        public List<string> Errors { get; set; } = [];
        public int FileLine { get; set; } = 0;

        public int Min_Fields_Required { get; set; }

        public List<Field> GetFields(string record, string separator = "|") {
            try
            {
                string[] fields = record.Split(separator);
                if (GlobalValidations<string>.HasElements(fields))
                {
                    string recordType = fields[0];
                    if (recordType.IsValidRecordType())
                    {
                        string recordTypeModel = recordType.GetModelByRecordType();
                        Type modelObjectType = GetObjectModelType(recordTypeModel);
                        object? modelObject;
                        if (modelObjectType == typeof(object))
                            modelObject = null;
                        else
                            modelObject = modelObjectType.GetConstructor([typeof(string)]).Invoke([record]);
                        return modelObject;
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

            return Fields;
        }
    }
}
