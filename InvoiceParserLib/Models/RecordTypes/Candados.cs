using InvoiceProcessor.Models.Entities;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Candados : Record
    {
        public Candados() : base("Candados", "516", 2) { }
        public Field Numero_Candado { get; set; } = new(1, string.Empty);
    }
}
