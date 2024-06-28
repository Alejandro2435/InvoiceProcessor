using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Destinatarios : Record
    {
        public Destinatarios() : base("Destinatarios", "520", 3) { }
        public Field Codigo_Destinatario { get; set; } = new(1, string.Empty);
        public Field NoFactura_Relacionada_Destinatario { get; set; } = new(2, string.Empty);
    }
}
