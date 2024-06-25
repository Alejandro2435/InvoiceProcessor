using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.DataAnotationsRegexFormats;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;
using ValidadorFacturasTXT.CustomValidations;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class Facturas : IRecordFactura
    {
        public Facturas() { }
        public Facturas(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private readonly Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Numero_Factura", 1},
            {"Fecha_Facturacion", 2},
            {"Termino_Facturacion", 3},
            {"Moneda_Facturacion", 4},
            {"Valor_Moneda_Extranjera", 5},
            {"Valor_Dolares", 6},
            {"Codigo_Proveedor", 7},
            {"Pais_Moneda", 9},
            {"Pais_Moneda_Fletes", 14},
            {"Pais_Moneda_Seguros", 15},
            {"Pais_Moneda_Embalajes", 16},
            {"Pais_Moneda_Otros_Incrementables", 17},
            {"Observaciones_Nivel_Factura", 18},
            {"Peso_Bruto", 19},
            {"Peso_Neto", 20},
            {"Bultos", 21},
            {"Fletes", 22},
            {"Seguros", 23},
            {"Embalajes", 24},
            {"Otros", 25},
            {"Origen_Mercancia", 26},
            {"Descargo_Mercancia", 27},
            {"Destino_Mercancia", 28},
            {"Codigo_Tipo_Bultos", 29},
            {"Tipo_Operacion", 30},
            {"Fecha_Expedicion", 31},
            {"Subdivision", 32},
            {"Certificado_Origen", 33},
            {"Observaciones", 34},
            {"eDocument", 35},
            {"Num_Referencia_Factura", 36},
            {"Clase_Aviso", 37},
            {"Tipo_Movimiento", 38},
            {"Enajenacion_Terminos_Articulo14CFF", 39},
            {"UUID", 40},
            {"Numero_Exportador_Autorizado", 42},
            {"Fletes_Decrementables", 43},
            {"Pais_Moneda_Fletes_Decrementables", 44},
            {"Seguros_Decrementables", 45},
            {"Pais_Moneda_Seguros_Decrementables", 46},
            {"Carga_Decrementables", 47},
            {"Pais_Moneda_Cargas_Decrementables", 48},
            {"Descargas_Decrementables", 49},
            {"Pais_Moneda_Descarga_Decrementables", 50},
            {"Otros_Decrementables", 51},
            {"Pais_Moneda_Otros_Decrementables", 52}
        };

        public string Tipo_Registro { get; set; }
        public string Numero_Factura { get; set; }
        public string Fecha_Facturacion { get; set; }
        public string Termino_Facturacion { get; set; }
        public string Moneda_Facturacion { get; set; }
        public double Valor_Moneda_Extranjera { get; set; }
        public double Valor_Dolares { get; set; }
        public string Codigo_Proveedor { get; set; }
        public string Pais_Moneda { get; set; }
        public string Pais_Moneda_Fletes { get; set; }
        public string Pais_Moneda_Seguros { get; set; }
        public string Pais_Moneda_Embalajes { get; set; }
        public string Pais_Moneda_Otros_Incrementables { get; set; }
        public string Observaciones_Nivel_Factura { get; set; }
        public string Peso_Bruto { get; set; }
        public string Peso_Neto { get; set; }
        public long Bultos { get; set; }
        public long Fletes { get; set; }
        public long Seguros { get; set; }
        public long Embalajes { get; set; }
        public long Otros { get; set; }
        public string Origen_Mercancia { get; set; }
        public string Descargo_Mercancia { get; set; }
        public string Destino_Mercancia { get; set; }
        public string Codigo_Tipo_Bultos { get; set; }
        public string Tipo_Operacion { get; set; }
        public string Fecha_Expedicion { get; set; }
        public string Subdivision { get; set; }
        public string Certificado_Origen { get; set; }
        public string Observaciones { get; set; }
        public string eDocument { get; set; }
        public string Num_Referencia_Factura { get; set; }
        public string Clase_Aviso { get; set; }
        public string Tipo_Movimiento { get; set; }
        public string Enajenacion_Terminos_Articulo14CFF { get; set; }
        public string UUID { get; set; }
        public string Numero_Exportador_Autorizado { get; set; }
        public long Fletes_Decrementables { get; set; }
        public string Pais_Moneda_Fletes_Decrementables { get; set; }
        public long Seguros_Decrementables { get; set; }
        public string Pais_Moneda_Seguros_Decrementables { get; set; }
        public long Carga_Decrementables { get; set; }
        public string Pais_Moneda_Cargas_Decrementables { get; set; }
        public long Descargas_Decrementables { get; set; }
        public string Pais_Moneda_Descarga_Decrementables { get; set; }
        public long Otros_Decrementables { get; set; }
        public string Pais_Moneda_Otros_Decrementables { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
