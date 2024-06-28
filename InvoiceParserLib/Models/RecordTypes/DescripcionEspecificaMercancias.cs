using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class DescripcionEspecificaMercancias : Record
    {
        public DescripcionEspecificaMercancias():base("Descripcion Especifica de Mercancias", "559", 5) { }

        public Field Marca { get; set; } = new(1, string.Empty);
        public Field Modelo { get; set; } = new(2, string.Empty);
        public Field Sub_Modelo { get; set; } = new(3, string.Empty);
        public Field Numero_Serie { get; set; } = new(4, string.Empty);
    }   
}
