using InvoiceProcessor.Models.Entities;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor.Models.RecordEntities
{
    class CasosNivelPedimento : Record
    {
        public CasosNivelPedimento() : base("Casos Nivel Pedimento", "507", 5) { }

        public Field Tipo_Caso { get; set; } = new(1, string.Empty);
        public Field Primer_Complemento_Caso { get; set; } = new(2, string.Empty);
        public Field Segundo_Complemento_Caso { get; set; } = new(3, string.Empty);
        public Field Tercer_Complemento_Caso { get; set; } =new(4, string.Empty);
    }
}
