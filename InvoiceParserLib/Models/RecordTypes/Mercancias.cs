
using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Mercancias : Record
    {
        public Mercancias() : base("Mercancías","552", 4) { }

        public Field Fraccion { get; set; } = new(1, string.Empty);
        public Field VIN_Numero_Serie { get; set; } = new(2, string.Empty);
        public Field<int> Kilometraje_Vehiculo { get; set; } = new(3, 0);
    }
}
