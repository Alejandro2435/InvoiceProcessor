using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor
{
    public class InvoiceValidator(Invoice invoice)
    {
        public readonly Invoice _invoice = invoice;

        public async Task<Invoice> Validate()
        {
            try
            {
                await Parallel.ForEachAsync(_invoice.Records, async (record, ct) =>
                {

                });
            }catch (Exception ex) { }
            return _invoice;
        }

        public async Task<object> ValidateRecord(Record record)
        {
            try
            {

            }catch (Exception ex) { }
            return record;
        }
    }
}
