using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class PedimentoAmericano : IRecordFactura
    {
        public PedimentoAmericano() { }
        public PedimentoAmericano(string record) 
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Tipo_Documento_Clase", 1},
            {"Numero", 2},
            {"Tipo_Documento_QR", 3}
        };

        public string Tipo_Registro { get; set; }
        public int Tipo_Documento_Clase { get; set; }
        public string Numero { get; set; }
        public int Tipo_Documento_QR { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
