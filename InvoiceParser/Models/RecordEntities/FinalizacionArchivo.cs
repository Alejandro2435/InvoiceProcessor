using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class FinalizacionArchivo : IRecordFactura
    {
        public FinalizacionArchivo() { }
        public FinalizacionArchivo(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0}
        };

        public string Tipo_Registro { get; set; }
        public int Numero_Campos_Registro { get; set; }

    }
}
