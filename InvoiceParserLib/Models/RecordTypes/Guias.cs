
using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Guias : Record
    {
        public Guias():base("Guías","503", 3) { }

        public Field Guia_Manifiesto { get; set; } = new(1, string.Empty);
        public Field Identificador_Guia { get; set; } = new(2, string.Empty);
    }
}
