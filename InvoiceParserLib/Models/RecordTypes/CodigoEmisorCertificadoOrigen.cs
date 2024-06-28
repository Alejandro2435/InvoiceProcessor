using InvoiceProcessor.Models.Entities;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor.Models.RecordEntities
{
    class CodigoEmisorCertificadoOrigen : Record
    {
        public CodigoEmisorCertificadoOrigen() : base("Codigo del Emisor del Certificado de Origen", "FFF", 3) { }

        public Field Clave_Fabricante_Productor { get; set; } = new(1, string.Empty);
        public Field Nombre_Fabricante_Productor { get; set; } = new(2, string.Empty);
    }
}
