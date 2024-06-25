using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class Destinatarios : IRecordFactura
    {
        public Destinatarios() { }
        public Destinatarios(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }
        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Numero_Candado", 1},
            {"NoFactura_Relacionada_Destinatario", 2}
        };

        public string Tipo_Registro { get; set; }
        public string Codigo_Destinatario { get; set; }
        public string NoFactura_Relacionada_Destinatario { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
