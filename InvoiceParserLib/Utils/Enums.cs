using InvoiceProcessor.Interfaces;
using InvoiceProcessor.Models.Entities;
using InvoiceProcessor.Models.RecordEntities;
using System.Collections.Concurrent;

namespace InvoiceProcessor.Utils
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

        public static readonly Dictionary<string, Record> RecordEntitiess = new()
        {
            { "501", new DatosGenerales() },
            { "CCC", new CodigoImportador() },
            { "502", new Transportistas() },
            { "503", new Guias() },
            { "504", new Contenedores() },
            { "PAM", new PedimentoAmericano() },
            { "505", new Facturas() },
            { "PPP", new CodigoProveedor() },
            { "FFF", new CodigoEmisorCertificadoOrigen() },
            { "506", new Fechas() },
            { "507", new CasosNivelPedimento() },
            { "511", new ObservacionesFactura() },
            { "512", new Descargas() },
            { "516", new Candados() },
            { "520", new Destinatarios() },
            { "551", new Partidas() },
            { "552", new Mercancias() },
            { "553", new Permisos() },
            { "554", new CasosNivelPartidas() },
            { "558", new ObservacionesPartidas() },
            { "559", new DescripcionEspecificaMercancias() },
            { "PCP", new InformacionCartaPorte() },
            { "999", new FinalizacionArchivo() }
        };

        public static readonly ConcurrentDictionary<string, Record> RecordEntities = new(RecordEntitiess);
    }
}
