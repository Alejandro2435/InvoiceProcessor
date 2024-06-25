using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;
using ValidadorFacturasTXT.CustomValidations;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class CodigoImportador : IRecordFactura
    {
        public CodigoImportador() { }
        public CodigoImportador(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Numero_Cliente", 1},
            {"Nombre", 2},
            {"Apellido_Paterno", 3},
            {"Apellido_Materno", 4},
            {"Calle", 5},
            {"Numero_Interior", 6},
            {"Numero_Exterior", 7},
            {"Ciudad", 8},
            {"Codigo_Postal", 9},
            {"Estado", 10},
            {"Pais", 11},
            {"Entidad", 12},
            {"RFC", 13},
            {"CURP", 14},
            {"Tipo", 15},
            {"Proveedor", 16},
            {"Zona_Default", 17},
            {"Transporte_Arribo", 18},
            {"Transporte_Salida", 19},
            {"Transporte_Territorio", 20},
            {"Password", 21},
            {"Colonia", 22},
            {"Municipio", 23},
            {"Avisar_TLC", 24},
            {"Aplicar_TLC", 25},
            {"Desplegar_Precios_Estimados", 26},
            {"Desplegar_IEPS", 27},
            {"Aplicar_IEPS", 28},
            {"Preguntar_Azucar", 29},
            {"Revisar_SECOFI", 30},
            {"Desplegar_Avisos_Automaticos", 31},
            {"Desplegar_Notas_Extra", 32},
            {"Desplegar_Cuotas_Compensatorias", 33},
            {"Desplegar_Descripciones_Especificas", 34},
            {"Desplegar_NOMS", 35},
            {"Aplicar_NOMS", 36},
            {"Eximir_NOMS_Por", 37},
            {"Desplegar_Padron_Sectorial", 38},
            {"Desplegar_Aduanas_Autorizadas", 39},
            {"Desplegar_Permisos", 40},
            {"Desplegar_Etiquetas", 41},
            {"Aplicar_Etiquetado", 42},
            {"Eximir_Etiquetado", 43},
            {"Verificar_Peso", 44},
            {"Verificar_Valor_Comercial", 45},
            {"Uso_Mercancia", 46},
            {"Estado_Mercancia", 47},
            {"Metodo_Valoracion", 48},
            {"Vinculacion", 49},
            {"Campo_Extra", 50}
        };

        public string Tipo_Registro { get; set; }
        public string Numero_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Calle { get; set; }
        public string Numero_Interior { get; set; }
        public string Numero_Exterior { get; set; }
        public string Ciudad { get; set; }
        public string Codigo_Postal { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Entidad { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string Tipo { get; set; }
        public string Proveedor { get; set; }
        public string Zona_Default { get; set; }
        public string Transporte_Arribo { get; set; }
        public string Transporte_Salida { get; set; }
        public string Transporte_Territorio { get; set; }
        public string Password { get; set; }
        [OptionalField(1, 120, null, null)]
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Avisar_TLC { get; set; }
        public string Aplicar_TLC { get; set; }
        public string Desplegar_Precios_Estimados { get; set; }
        public string Desplegar_IEPS { get; set; }
        public string Aplicar_IEPS { get; set; }
        public string Preguntar_Azucar { get; set; }
        public string Revisar_SECOFI { get; set; }
        public string Desplegar_Avisos_Automaticos { get; set; }
        public string Desplegar_Notas_Extra { get; set; }
        public string Desplegar_Cuotas_Compensatorias { get; set; }
        public string Desplegar_Descripciones_Especificas { get; set; }
        public string Desplegar_NOMS { get; set; }
        public string Aplicar_NOMS { get; set; }
        public string Eximir_NOMS_Por { get; set; }
        public string Desplegar_Padron_Sectorial { get; set; }
        public string Desplegar_Aduanas_Autorizadas { get; set; }
        public string Desplegar_Permisos { get; set; }
        public string Desplegar_Etiquetas { get; set; }
        public string Aplicar_Etiquetado { get; set; }
        public string Eximir_Etiquetado { get; set; }
        public string Verificar_Peso { get; set; }
        public string Verificar_Valor_Comercial { get; set; }
        public string Uso_Mercancia { get; set; }
        public string Estado_Mercancia { get; set; }
        public string Metodo_Valoracion { get; set; }
        public string Vinculacion { get; set; }
        public string Campo_Extra { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
