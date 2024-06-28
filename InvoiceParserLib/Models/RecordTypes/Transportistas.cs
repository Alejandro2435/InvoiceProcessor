using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Transportistas : Record
    {
        public Transportistas() : base("Transportistas", "502", 5) { }

        public Field Codigo_Transportista { get; set; } = new(1, string.Empty);
        public Field ID_Vehiculo { get; set; } = new(2, string.Empty);
        public Field Pais { get; set; } = new(3, string.Empty);
        public Field Equipo_Ferroviario { get; set; } = new(4, string.Empty);
    }
}
