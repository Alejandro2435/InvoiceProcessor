using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Interfaces
{
    public interface IInvoiceRecord
    {
        string Name { get; }
        Field Type { get ; }
        string Content { get; set; }
        int FileLine { get; set; }
        int FieldsCount {  get; }
        bool IsUnique {  get; }
        void SetPropertyValues(List<Field> fields);
    }
}
