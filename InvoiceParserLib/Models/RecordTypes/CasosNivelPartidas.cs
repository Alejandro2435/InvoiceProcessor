using InvoiceProcessor.Models.Entities;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class CasosNivelPartidas : Record
    {
        public CasosNivelPartidas() : base("Casos Nivel Partida", "554", 7) { }

        public Field Tipo_Caso { get; set; } = new(1, string.Empty);
        public Field Primer_Complemento_Caso { get; set; } = new(2, string.Empty);
        public Field Segundo_Complemento_Caso { get; set; } = new(3, string.Empty);
        public Field Tercer_Complemento_Caso { get; set; } = new(4, string.Empty);
        public Field Valor_Comercial { get; set; } = new(5, string.Empty);
        public Field Codigo_Proveedor { get; set; } = new(6, string.Empty);
    }
}
