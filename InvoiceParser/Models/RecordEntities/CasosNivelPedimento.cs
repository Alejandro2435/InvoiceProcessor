using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    class CasosNivelPedimento : IRecordFactura
    {
        public CasosNivelPedimento() { }
        public CasosNivelPedimento(string record) 
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Tipo_Caso", 1},
            {"PrimerComplementoCaso", 2},
            {"SegundoComplementoCaso", 3},
            {"TercerComplementoCaso", 4}
        };

        public string Tipo_Registro { get; set; }
        public string Tipo_Caso { get; set; }
        public string PrimerComplementoCaso { get; set; }
        public string SegundoComplementoCaso { get; set; }
        public string TercerComplementoCaso { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
