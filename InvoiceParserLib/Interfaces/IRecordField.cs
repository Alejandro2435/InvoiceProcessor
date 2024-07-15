namespace InvoiceProcessor.Interfaces
{
    public interface IRecordField<T>
    {
        int Index { get; }
        T Value { get; set; }
    }
}
