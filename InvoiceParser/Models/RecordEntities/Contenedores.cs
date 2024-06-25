using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class Contenedores : IRecordFactura
    {
        public Contenedores() { }
        public Contenedores(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Numero_Contenedor", 1},
            {"Tipo_Contenedor", 2}
        };

        public string Tipo_Registro { get; set; }
        public string Numero_Contenedor { get; set; }
        public string Tipo_Contenedor { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
