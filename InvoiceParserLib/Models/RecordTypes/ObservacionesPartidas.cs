using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class ObservacionesPartidas : Record
    {
        public ObservacionesPartidas() : base("Observaciones Partidas","558", 2) { }

        public Field Observaciones { get; set; } = new(2, string.Empty);
    }
}
