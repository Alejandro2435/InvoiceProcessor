using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class InformacionCartaPorte : IRecordFactura
    {
        public InformacionCartaPorte() { }
        public InformacionCartaPorte(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Clave_Material_Peligroso", 1},
            {"Clave_Tipo_Embalaje", 2}
        };

        public string Tipo_Registro { get; set; }
        public string Clave_Material_Peligroso { get; set; }
        public string Clave_Tipo_Embalaje { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
