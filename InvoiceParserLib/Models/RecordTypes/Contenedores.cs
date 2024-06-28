using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Contenedores : Record
    {
        public Contenedores() : base("Contenedores","504", 3) { }
        public Field Numero_Contenedor { get; set; } = new(1, string.Empty);
        public Field Tipo_Contenedor { get; set; } = new(2, string.Empty);
    }
}
