using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    class Fechas : IRecordFactura
    {
        public Fechas() { }
        public Fechas(string record) 
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Tipo_Fecha", 1},
            {"Fecha", 2} 
        };

        public string Tipo_Registro { get; set; }
        public string Tipo_Fecha { get; set; }
        public string Fecha { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
