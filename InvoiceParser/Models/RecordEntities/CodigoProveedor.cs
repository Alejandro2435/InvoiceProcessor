using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    class CodigoProveedor : IRecordFactura
    {
        public CodigoProveedor() { }
        public CodigoProveedor(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Clave_Proveedor", 1},
            {"IRS", 2},
            {"Nombre_Proveedor", 3},
            {"Apellido_Paterno", 4},
            {"Apellido_Materno", 5},
            {"Calle", 6},
            {"Numero_Interior", 7},
            {"Numero_Exterior", 8},
            {"Codigo_Postal", 9},
            {"Ciudad", 10},
            {"Pais", 11},
            {"Entidad", 12},
            {"Vinculacion", 13}
        };

        public string Tipo_Registro { get; set; }
        public string Clave_Proveedor { get; set; }
        public string IRS { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Calle { get; set; }
        public string Numero_Interior { get; set; }
        public string Numero_Exterior { get; set; }
        public string Codigo_Postal { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Entidad { get; set; }
        public string Vinculacion { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
