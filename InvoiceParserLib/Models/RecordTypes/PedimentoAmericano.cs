using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class PedimentoAmericano : Record
    {
        public PedimentoAmericano() : base("Pedimento Americano","PAM", 4) { }

        public Field<int> Tipo_Documento_Clase { get; set; } = new(1, 0);
        public Field Numero { get; set; } = new(2, string.Empty);
        public Field<int> Tipo_Documento_QR { get; set; } = new(3, 0);
    }
}
