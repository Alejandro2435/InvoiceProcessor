using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Permisos : Record
    {
        public Permisos() : base("Permisos","553",6) { }

        public Field Clave_Permiso { get; set; } = new(1, string.Empty);
        public Field Numero_Permiso { get; set; } = new(2, string.Empty);
        public Field Firma_Descargo { get; set; } = new(3, string.Empty);
        public Field Valor_Comercial_Dolares { get; set; } = new(4, string.Empty);
        public Field Cantidad_Tarifa { get; set; } = new(5, string.Empty);
    }
}
