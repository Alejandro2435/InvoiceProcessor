using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.DataAnotationsRegexFormats;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;
using ValidadorFacturasTXT.CustomValidations;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class Guias : IRecordFactura
    {
        public Guias() { }
        public Guias(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        public Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Guia_Manifiesto", 1},
            {"Identificador_Guia", 2}
        };

        public string Tipo_Registro { get; set; }
        public string Guia_Manifiesto { get; set; }
        public string Identificador_Guia { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
