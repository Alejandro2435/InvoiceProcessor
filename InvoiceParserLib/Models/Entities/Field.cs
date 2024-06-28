using InvoiceProcessor.Interfaces;

namespace InvoiceProcessor.Models.Entities
{
    public class Field<T>(int index, T value)
    {
        public int Index { get; } = index;
        public T Value { get; set; } = value;
    }
    public class Field(int index, string value) : Field<string>(index, value) { }
}
