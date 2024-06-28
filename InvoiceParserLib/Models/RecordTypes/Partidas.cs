using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Partidas : Record
    {
        public Partidas() : base("Partidas", "551", 49) { }
        public Field Fraccion { get; set; } = new(1, string.Empty);
        public Field Descripcion { get; set; } = new(2, string.Empty);
        public Field No_Parte { get; set; } = new(3, string.Empty);
        public Field Valor_Mercancia { get; set; } = new(4, string.Empty);
        public Field Cantidad_Comercial { get; set; } = new(5, string.Empty);
        public Field Unidad_Medida_Comercial { get; set; } = new(6, string.Empty);
        public Field Cantidad_Tarifa { get; set; } = new(7, string.Empty);
        public Field Valor_Agregado { get; set; } = new(8, string.Empty);
        public Field<int> Vinculacion { get; set; } = new(9, 0);
        public Field<int> Metodo_Valoracion { get; set; } = new(10, 0);
        public Field Marca { get; set; } = new(11, string.Empty);
        public Field Modelo { get; set; } = new(12, string.Empty);
        public Field Pais_Origen_Destino { get; set; } = new(13, string.Empty);
        public Field Pais_Comprador_Vendedor { get; set; } = new(14, string.Empty);
        public Field Correlacion_TIGIE { get; set; } = new(15, string.Empty);
        public Field Cantidad_UMF { get; set; } = new(16, string.Empty);
        public Field Unidad_Medida_Facturacion { get; set; } = new(17, string.Empty);
        public Field Descripcion_COVE { get; set; } = new(18, string.Empty);
        public Field Identificador_Arancel_Aplicar { get; set; } = new(19, string.Empty);
        public Field Clave_Industria_PPS_o_Acuerdo_Aladi { get; set; } = new(20, string.Empty);
        public Field Peso { get; set; } = new(21, string.Empty);
        public Field Uso_Mercancia { get; set; } = new(22, string.Empty);
        public Field Estado_Mercancia { get; set; } = new(23, string.Empty);
        public Field Moneda { get; set; } = new(24, string.Empty);
        public Field Tasa_Arancel_IGI { get; set; } = new(25, string.Empty);
        public Field Correlacion_Aladi { get; set; } = new(26, string.Empty);
        public Field Valor_Mercancias_No_Originarias { get; set; } = new(27, string.Empty);
        public Field Monto_IGI { get; set; } = new(28, string.Empty);
        public Field FP303 { get; set; } = new(29, string.Empty);
        public Field Kilogramos_Azucar { get; set; } = new(30, string.Empty);
        public Field Pais_Moneda { get; set; } = new(31, string.Empty);
        public Field FP_IVA { get; set; } = new(33, string.Empty);
        public Field FP_IGI_IGE { get; set; } = new(34, string.Empty);
        public Field Precio_Unitario { get; set; } = new(35, string.Empty);
        public Field Valor_En_Aduana { get; set; } = new(36, string.Empty);
        public Field Valor_En_Dolares { get; set; } = new(37, string.Empty);
        public Field<int> UMT { get; set; } = new(38, 0);
        public Field Peso_Neto_Unitario_En_Kg { get; set; } = new(39, string.Empty);
        public Field Peso_Bruto_Unitario_En_Kg { get; set; } = new(40, string.Empty);
        public Field Orden_de_Compra { get; set; } = new(41, string.Empty);
        public Field Numero_de_Factura { get; set; } = new(42, string.Empty);
        public Field Guia_Master { get; set; } = new(43, string.Empty);
        public Field Guia_House { get; set; } = new(44, string.Empty);
        public Field Rendimiento_en_Lt { get; set; } = new(45, string.Empty);
        public Field Codigo_NICO { get; set; } = new(46, string.Empty);
        public Field<long> Bultos { get; set; } = new(47, 0);
        public Field<long> Código_del_Producto { get; set; } = new(48, 0);
    }
}
