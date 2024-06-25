using InvoiceParserLib.Interfaces;
using InvoiceParserLib.Models.Entities;
using ValidadorFacturasTXT.Models.RecordEntities;

namespace InvoiceParserLib.Utils
{
    public static class Enums
    {
        public enum Separator
        {
            pipe = '|'
        }

        public enum OriginOfInvoiceContent
        {
            FromString,
            FromFilePath
        }

        public static readonly Dictionary<string, Record> RecordEntities = new()
        {
            //{ "501", new Record() },
            //{ "CCC", new Record() },
            //{ "502", new Record() },
            //{ "503", new Record() },
            //{ "504", new Record() },
            //{ "PAM", new Record() },
            //{ "505", new Record() },
            //{ "PPP", new Record() },
            //{ "FFF", new Record() },
            //{ "506", new Record() },
            //{ "507", new Record() },
            //{ "511", new Record() },
            //{ "512", new Record() },
            //{ "516", new Record() },
            //{ "520", new Record() },
            { "551", new Partidas() },
            //{ "552", new Record() },
            //{ "553", new Record() },
            //{ "554", new Record() },
            //{ "558", new Record() },
            //{ "559", new Record() },
            //{ "PCP", new Record() },
            //{ "999", new Record() }
        };
    }
}
