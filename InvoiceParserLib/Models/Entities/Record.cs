using InvoiceParserLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceParserLib.Models.Entities
{
    public class Record : IInvoiceRecord
    {
        public Record(string name, string type, int fieldsCount) 
        {
            Name = name;
            Type = type;
            FieldsCount = fieldsCount;
        }
        public string Name { get; } = "";
        public string Type { get; } = "";
        public string Content { get; set; } = string.Empty;
        public int FileLine { get; set; }
        public int FieldsCount { get; } = 0;

        public virtual void SetPropertyValues(List<Field> fields) { }
    }
}
