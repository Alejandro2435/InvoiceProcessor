using static InvoiceParser.Utils.Enums;

namespace InvoiceParser.Models
{
    public class Field
    {
        public int Index { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public FieldTypeOfRecord Type { get; set; } = FieldTypeOfRecord.String;
        public object? Value { get; set; }
    }
}
