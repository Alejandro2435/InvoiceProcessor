using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    class CodigoEmisorCertificadoOrigen : IRecordFactura
    {
        public CodigoEmisorCertificadoOrigen() { }
        public CodigoEmisorCertificadoOrigen(string record) {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Clave_Fabricante_Productor", 1},
            {"Nombre_Fabricante_Productor", 2}
        };

        public string Tipo_Registro { get; set; }
        public string Clave_Fabricante_Productor { get; set; }
        public string Nombre_Fabricante_Productor { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
