using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    class CodigoProveedor : Record
    {
        public CodigoProveedor():base("Codigo del Proveedor", "PPP", 14) { }
        public Field Clave_Proveedor { get; set; } = new(1,string.Empty);
        public Field IRS { get; set; } = new(2,string.Empty);
        public Field Nombre_Proveedor { get; set; } = new(3,string.Empty);
        public Field Apellido_Paterno { get; set; } = new(4,string.Empty);
        public Field Apellido_Materno { get; set; } = new(5,string.Empty);
        public Field Calle { get; set; } = new(6,string.Empty);
        public Field Numero_Interior { get; set; } = new(7,string.Empty);
        public Field Numero_Exterior { get; set; } = new(8,string.Empty);
        public Field Codigo_Postal { get; set; } = new(9,string.Empty);
        public Field Ciudad { get; set; } = new(10,string.Empty);
        public Field Pais { get; set; } = new(11,string.Empty);
        public Field Entidad { get; set; } = new(12,string.Empty);
        public Field Vinculacion { get; set; } = new(13,string.Empty);
    }
}
