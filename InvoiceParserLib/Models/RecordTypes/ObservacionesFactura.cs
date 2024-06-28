
using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class ObservacionesFactura : Record
    {
        public ObservacionesFactura() : base("Observaciones Factura","511", 2) { }

        public Field Observaciones { get; set; } = new(2, string.Empty);
    }
}
