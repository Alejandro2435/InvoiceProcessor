using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class Permisos : IRecordFactura
    {
        public Permisos() { }
        public Permisos(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Clave_Permiso", 1},
            {"Numero_Permiso", 2},
            {"Firma_Descargo", 3},
            {"Valor_Comercial_Dolares", 4},
            {"Cantidad_Tarifa", 5}
        };

        public string Tipo_Registro { get; set; }
        public string Clave_Permiso { get; set; }
        public string Numero_Permiso { get; set; }
        public string Firma_Descargo { get; set; }
        public string Valor_Comercial_Dolares { get; set; }
        public string Cantidad_Tarifa { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
