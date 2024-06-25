using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class Transportistas : IRecordFactura
    {
        public Transportistas() { }
        public Transportistas(string record) 
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Codigo_Transportista", 1},
            {"ID_Vehiculo", 2},
            {"Pais", 3},
            {"Equipo_Ferroviario", 4},
        };

        public string Tipo_Registro { get; set; }
        public string Codigo_Transportista { get; set; }
        public string ID_Vehiculo { get; set; }
        public string Pais { get; set; }
        public string Equipo_Ferroviario { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
