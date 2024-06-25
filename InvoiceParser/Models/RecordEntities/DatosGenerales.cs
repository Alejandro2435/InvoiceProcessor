using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class DatosGenerales : IRecordFactura
    {
        public DatosGenerales() { }
        public DatosGenerales(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }

        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Tipo_Operacion", 1},
            {"Clave_Documento", 2},
            {"Numero_Pedimento", 3},
            {"Codigo_Importador", 4},
            {"Fletes", 5},
            {"Seguros", 6},
            {"Embalajes", 7},
            {"Otros_Incrementables", 8},
            {"Otros_Deducibles", 9},
            {"Peso_Bruto", 10},
            {"Bultos", 11},
            {"Transporte_Entrada_Salida", 12},
            {"Transporte_Arribo", 13},
            {"Transporte_Salida_Aduana", 14},
            {"Destino_o_Zona", 15},
            {"Referencia", 16},
            {"Pesos", 17},
            {"Tipo_Archivo", 18},
            {"Pais_Moneda", 19},
            {"Pais_Moneda_Fletes", 20},
            {"Pais_Moneda_Seguros", 21},
            {"Pais_Moneda_Embalajes", 22},
            {"Pais_Moneda_Otros_Incrementables", 23},
            {"Marcas_Numeros_Bultos", 24},
            {"Grupo_Factura", 25},
            {"Fletes_Decrementables", 26},
            {"Pais_Moneda_Fletes_Decrementables", 27},
            {"Seguros_Decrementables", 28},
            {"Pais_Moneda_Seguros_Decrementables", 29},
            {"Carga_Decrementables", 30},
            {"Pais_Moneda_Cargas_Decrementables", 31},
            {"Descargas_Decrementables", 32},
            {"Pais_Moneda_Descarga_Decrementables", 33},
            {"Otros_Decrementables", 34},
            {"Pais_Moneda_Otros_Decrementables", 35}
        };

        public string Tipo_Registro { get; set; }
        public string Tipo_Operacion { get; set; }
        public string Clave_Documento { get; set; }
        public string Numero_Pedimento { get; set; }
        public string Codigo_Importador { get; set; }
        public long Fletes { get; set; }
        public long Seguros { get; set; }
        public long Embalajes { get; set; }
        public long Otros_Incrementables { get; set; }
        public long Otros_Deducibles { get; set; }
        public string Peso_Bruto { get; set; }
        public long Bultos { get; set; }
        public string Transporte_Entrada_Salida { get; set; }
        public string Transporte_Arribo { get; set; }
        public string Transporte_Salida_Aduana { get; set; }
        public string Destino_o_Zona { get; set; }
        public string Referencia { get; set; }
        public int Pesos { get; set; }
        public string Tipo_Archivo { get; set; }
        public string Pais_Moneda { get; set; }
        public string Pais_Moneda_Fletes { get; set; }
        public string Pais_Moneda_Seguros { get; set; }
        public string Pais_Moneda_Embalajes { get; set; }
        public string Pais_Moneda_Otros_Incrementables { get; set; }
        public string Marcas_Numeros_Bultos { get; set; }
        public string Grupo_Factura { get; set; }
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
