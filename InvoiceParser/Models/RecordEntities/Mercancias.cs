using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class Mercancias: IRecordFactura
    {
        public Mercancias() { }
        public Mercancias(string record) 
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Fraccion", 1},
            {"VIN_Numero_Serie", 2},
            {"Kilometraje_Vehiculo", 3}
        };

        public string Tipo_Registro { get; set; }
        public string Fraccion { get; set; }
        public string VIN_Numero_Serie { get; set; }
        public int Kilometraje_Vehiculo { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
