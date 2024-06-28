
using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Fechas : Record
    {
        public Fechas():base("Fechas","506", 3) { }

        public Field Tipo_Fecha { get; set; } = new(1, string.Empty);
        public Field Fecha { get; set; } = new(2, string.Empty);
    }
}
