using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class DescripcionEspecificaMercancias : IRecordFactura
    {
        public DescripcionEspecificaMercancias() { }
        public DescripcionEspecificaMercancias(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Marca", 1},
            {"Modelo", 2},
            {"Sub_Modelo", 3},
            {"Numero_Serie", 4}
        };

        public string Tipo_Registro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Sub_Modelo { get; set; }
        public string Numero_Serie { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
