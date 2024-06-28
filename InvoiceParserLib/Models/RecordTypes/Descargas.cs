using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    class Descargas : Record
    {
        public Descargas():base("Descargas", "512", 10) { }

        public Field Patente_Original { get; set; } = new(1, string.Empty);
        public Field Pedimento_Original { get; set; } = new(2, string.Empty);
        public Field Clave_Original { get; set; } = new(3, string.Empty);
        public Field Fecha_Original { get; set; } = new(4, string.Empty);
        public Field<long> Fraccion_Original { get; set; } = new(5, 0);
        public Field<long> Cantidad { get; set; } = new(6, 0);
        public Field Unidad_Medida_Original { get; set; } = new(7, string.Empty);
        public Field Aduana_Original { get; set; } = new(8, string.Empty);
        public Field<int> Año_Validacion { get; set; } = new(9, 0);
    }
}
