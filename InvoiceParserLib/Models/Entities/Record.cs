using InvoiceProcessor.Interfaces;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor.Models.Entities
{
    public class Record : IInvoiceRecord
    {
        public Record(string name, string type, int fieldsCount, bool isUnique = false) 
        {
            Name = name;
            Type = new(0, type);
            FieldsCount = fieldsCount;
            IsUnique = isUnique;
        }
        public string Name { get; } = string.Empty;
        public Field Type { get; } = new(0, string.Empty);
        public string Content { get; set; } = string.Empty;
        public int FileLine { get; set; }
        public int FieldsCount { get; } = 0;
        public bool IsUnique { get; } = false;

        public void SetPropertyValues(List<Field> fields) {
            AssignPropertyValue(this, fields);
        }
    }
}
