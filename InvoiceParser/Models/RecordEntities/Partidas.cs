using System.Collections.Generic;
using ValidadorFacturasTXT.Models.Interfaces;
using static ValidadorFacturasTXT.Utils.GlobalFunctions;

namespace ValidadorFacturasTXT.Models.RecordEntities
{
    public class Partidas : IRecordFactura
    {
        public Partidas() { }
        public Partidas(string record)
        {
            Numero_Campos_Registro = GetRecordFieldsNumber(record);
            SetValuesToProperties(this, record, modelProperties);
        }
        private Dictionary<string, int> modelProperties = new Dictionary<string, int>
        {
            {"Tipo_Registro", 0},
            {"Fraccion", 1},
            {"Descripcion", 2},
            {"No_Parte", 3},
            {"Valor_Mercancia", 4},
            {"Cantidad_Comercial", 5},
            {"Unidad_Medida_Comercial", 6},
            {"Cantidad_Tarifa", 7},
            {"Valor_Agregado", 8},
            {"Vinculacion", 9},
            {"Metodo_Valoracion", 10},
            {"Marca", 11},
            {"Modelo", 12},
            {"Pais_Origen_Destino", 13},
            {"Pais_Comprador_Vendedor", 14},
            {"Correlacion_TIGIE", 15},
            {"Cantidad_UMF", 16},
            {"Unidad_Medida_Facturacion", 17},
            {"Descripcion_COVE", 18},
            {"Identificador_Arancel_Aplicar", 19},
            {"Clave_Industria_PPS_o_Acuerdo_Aladi", 20},
            {"Peso", 21},
            {"Uso_Mercancia", 22},
            {"Estado_Mercancia", 23},
            {"Moneda", 24},
            {"Tasa_Arancel_IGI", 25},
            {"Correlacion_Aladi", 26},
            {"Valor_Mercancias_No_Originarias", 27},
            {"Monto_IGI", 28},
            {"FP303", 29},
            {"Kilogramos_Azucar", 30},
            {"Pais_Moneda", 31},
            {"FP_IVA", 33},
            {"FP_IGI_IGE", 34},
            {"Precio_Unitario", 35},
            {"Valor_En_Aduana", 36},
            {"Valor_En_Dolares", 37},
            {"UMT", 38},
            {"Peso_Neto_Unitario_En_Kg", 39},
            {"Peso_Bruto_Unitario_En_Kg", 40},
            {"Orden_de_Compra", 41},
            {"Numero_de_Factura", 42},
            {"Guia_Master", 43},
            {"Guia_House", 44},
            {"Rendimiento_en_Lt", 45},
            {"Codigo_NICO", 46},
            {"Bultos", 47},
            {"Código_del_Producto", 48}

        };

        public string Tipo_Registro { get; set; }
        public string Fraccion { get; set; }
        public string Descripcion { get; set; }
        public string No_Parte { get; set; }
        public string Valor_Mercancia { get; set; }
        public string Cantidad_Comercial { get; set; }
        public string Unidad_Medida_Comercial { get; set; }
        public string Cantidad_Tarifa { get; set; }
        public string Valor_Agregado { get; set; }
        public int Vinculacion { get; set; }
        public int Metodo_Valoracion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Pais_Origen_Destino { get; set; }
        public string Pais_Comprador_Vendedor { get; set; }
        public string Correlacion_TIGIE { get; set; }
        public string Cantidad_UMF { get; set; }
        public string Unidad_Medida_Facturacion { get; set; }
        public string Descripcion_COVE { get; set; }
        public string Identificador_Arancel_Aplicar { get; set; }
        public string Clave_Industria_PPS_o_Acuerdo_Aladi { get; set; }
        public string Peso { get; set; }
        public string Uso_Mercancia { get; set; }
        public string Estado_Mercancia { get; set; }
        public string Moneda { get; set; }
        public string Tasa_Arancel_IGI { get; set; }
        public string Correlacion_Aladi { get; set; }
        public string Valor_Mercancias_No_Originarias { get; set; }
        public string Monto_IGI { get; set; }
        public string FP303 { get; set; }
        public string Kilogramos_Azucar { get; set; }
        public string Pais_Moneda { get; set; }
        public string FP_IVA { get; set; }
        public string FP_IGI_IGE { get; set; }
        public string Precio_Unitario { get; set; }
        public string Valor_En_Aduana { get; set; }
        public string Valor_En_Dolares { get; set; }
        public int UMT { get; set; }
        public string Peso_Neto_Unitario_En_Kg { get; set; }
        public string Peso_Bruto_Unitario_En_Kg { get; set; }
        public string Orden_de_Compra { get; set; }
        public string Numero_de_Factura { get; set; }
        public string Guia_Master { get; set; }
        public string Guia_House { get; set; }
        public string Rendimiento_en_Lt { get; set; }
        public string Codigo_NICO { get; set; }
        public long Bultos { get; set; }
        public long Código_del_Producto { get; set; }
        public int Numero_Campos_Registro { get; set; }
    }
}
