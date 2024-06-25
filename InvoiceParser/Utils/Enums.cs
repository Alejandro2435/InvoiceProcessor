using InvoiceParser.Models;
using InvoiceParser.Models.Interfaces;
using System.Collections.Generic;
using ValidadorFacturasTXT.Models.RecordEntities;

namespace InvoiceParser.Utils
{
    public class Enums
    {
        #region Dictionaries
        /*
            Los struct que refieran a los índices donde se encuentra un campo en un registro, el cual contiene
            en su nombre 'FieldIndex', comienzan en el 0 pero en el PDF del LayOut comienzan en 1 por lo que
            si se desea saber en qué índice se encuentra un campo se debe sumar un 1 al valor en el struct para
            saber a qué campo se refiere en el PDF.
        */
        public static readonly Dictionary<string, string> dic_TiposRegistro = new Dictionary<string, string>()
        {
            { "501", "Datos Generales" },
            { "CCC", "Codigo Importador" },
            { "502", "Transportistas" },
            { "503", "Guias" },
            { "504", "Contenedores" },
            { "PAM", "Pedimento Americano" },
            { "505", "Facturas" },
            { "PPP", "Codigo Proveedor"},
            { "FFF", "Codigo Emisor Certificado Origen"},
            { "506", "Fechas"},
            { "507", "Casos Nivel Pedimento"},
            { "511", "Observaciones Factura"},
            { "512", "Descargas"},
            { "516", "Candados"},
            { "520", "Destinatarios"},
            { "551", "Partidas"},
            { "552", "Mercancias"},
            { "553", "Permisos"},
            { "554", "Casos Nivel Partidas"},
            { "558", "Observaciones Partidas"},
            { "559", "Descripcion Especifica Mercancias"},
            { "PCP", "Informacion Carta Porte"},
            { "999", "Finalizacion Archivo"}
        };

        public static readonly Dictionary<string, IInvoiceRecord> dic_RecordEntities = new()
        {
            { "501", new Record() },
            { "CCC", new Record() },
            { "502", new Record() },
            { "503", new Record() },
            { "504", new Record() },
            { "PAM", new Record() },
            { "505", new Record() },
            { "PPP", new Record() },
            { "FFF", new Record() },
            { "506", new Record() },
            { "507", new Record() },
            { "511", new Record() },
            { "512", new Record() },
            { "516", new Candados() },
            { "520", new Record() },
            { "551", new Record() },
            { "552", new Record() },
            { "553", new Record() },
            { "554", new Record() },
            { "558", new Record() },
            { "559", new Record() },
            { "PCP", new Record() },
            { "999", new Record() }
        };
        #endregion

        #region Enums
        public enum OriginOfInvoiceContent
        {
            FromString,
            FromFilePath
        }

        public enum FieldTypeOfRecord
        {
            String,
            Numeric,
            DateTime
        }

        #endregion

        #region String Constants

        public const string DatosGenerales = "501";
        public const string CodigoImportador = "CCC";
        public const string Transportistas = "502";
        public const string Guias = "503";
        public const string Contenedores = "504";
        public const string PedimentoAmericano = "PAM";
        public const string Facturas = "505";
        public const string CodigoProveedor = "PPP";
        public const string CodigoEmisorCertificadoOrigen = "FFF";
        public const string Fechas = "506";
        public const string CasosNivelPedimento = "507";
        public const string ObservacionesFactura = "511";
        public const string Descargas = "512";
        public const string Candados = "516";
        public const string Destinatarios = "520";
        public const string Partidas = "551";
        public const string Mercancias = "552";
        public const string Permisos = "553";
        public const string CasosNivelPartida = "554";
        public const string ObservacionesPartidas = "558";
        public const string DescripcionEspecificaMercancias = "559";
        public const string InformacionCartaPorte = "PCP";
        public const string FinalizacionArchivo = "999";

        #endregion
    }
}
