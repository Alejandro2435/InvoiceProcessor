using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class InformacionCartaPorte : Record
    {
        public InformacionCartaPorte() : base("Información Carta Porte","PCP",3) { }

        public Field Clave_Material_Peligroso { get; set; } = new(1, string.Empty);
        public Field Clave_Tipo_Embalaje { get; set; } = new(2, string.Empty);
    }
}
