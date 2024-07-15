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
        List<string> Errors { get; set; }
        bool IsValid { get; set; }
        void SetPropertyValues(List<Field> fields);
        void ValidateRecord();
    }
}
