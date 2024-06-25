using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.DataAnotationsRegexFormats;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;
using ValidadorFacturasTXT.CustomValidations;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class CasosNivelPartidas : IRecordFactura
    {
        public CasosNivelPartidas() { }
        public CasosNivelPartidas(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Tipo_Caso", 1},
            {"Primer_Complemento_Caso", 2},
            {"Segundo_Complemento_Caso", 3},
            {"Tercer_Complemento_Caso", 4},
            {"Valor_Comercial", 5},
            {"Codigo_Proveedor", 6},
        };

        public string Tipo_Registro { get; set; }
        public string Tipo_Caso { get; set; }
        public string Primer_Complemento_Caso { get; set; }
        public string Segundo_Complemento_Caso { get; set; }
        public string Tercer_Complemento_Caso { get; set; }
        public string Valor_Comercial { get; set; }
        public string Codigo_Proveedor { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
