using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    class Descargas : IRecordFactura
    {
        public Descargas() { }
        public Descargas(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Patente_Original", 1},
            {"Pedimento_Original", 2},
            {"Clave_Original", 3},
            {"Fecha_Original", 4},
            {"Fraccion_Original", 5},
            {"Cantidad", 6},
            {"Unidad_Medida_Original", 7},
            {"Aduana_Original", 8},
            {"Año_Validacion", 9}
        };

        public string Tipo_Registro { get; set; }
        public string Patente_Original { get; set; }
        public string Pedimento_Original { get; set; }
        public string Clave_Original { get; set; }
        public string Fecha_Original { get; set; }
        public long Fraccion_Original { get; set; }
        public long Cantidad { get; set; }
        public string Unidad_Medida_Original { get; set; }
        public string Aduana_Original { get; set; }
        public int Año_Validacion { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
