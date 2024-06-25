using InvoiceParser.Models;
using System.Collections.Generic;
using InvoiceParser.Models.Interfaces;
using static InvoiceParser.Utils.Globals;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class Candados : IInvoiceRecord
    {
        private readonly Dictionary<string, int> ModelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Numero_Candado", 1}
        };
        public Candados() { }
        public Candados(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, ModelProperties);
        }

        public string Tipo_Registro { get; set; } = string.Empty;
        public string Numero_Candado { get; set; } = string.Empty;
        public int Numero_Campos_Registro { get; set; } = 0;
    }
}
