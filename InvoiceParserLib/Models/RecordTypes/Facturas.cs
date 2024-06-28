using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Facturas : Record
    {
        public Facturas() : base("Facturas","505", 53) { }

        public Field Numero_Factura { get; set; } = new(1, string.Empty);
        public Field Fecha_Facturacion { get; set; } = new(2, string.Empty);
        public Field Termino_Facturacion { get; set; } = new(3, string.Empty);
        public Field Moneda_Facturacion { get; set; } = new(4, string.Empty);
        public Field<double> Valor_Moneda_Extranjera { get; set; } = new(5, 0);
        public Field<double> Valor_Dolares { get; set; } = new(6, 0);
        public Field Codigo_Proveedor { get; set; } = new(7, string.Empty);
        public Field Pais_Moneda { get; set; } = new(9, string.Empty);
        public Field Pais_Moneda_Fletes { get; set; } = new(14, string.Empty); 
        public Field Pais_Moneda_Seguros { get; set; } = new(15, string.Empty);
        public Field Pais_Moneda_Embalajes { get; set; } = new(16, string.Empty);
        public Field Pais_Moneda_Otros_Incrementables { get; set; } = new(17, string.Empty);
        public Field Observaciones_Nivel_Factura { get; set; } = new(18, string.Empty);
        public Field Peso_Bruto { get; set; } = new(19, string.Empty);
        public Field Peso_Neto { get; set; } = new(20, string.Empty);
        public Field<long> Bultos { get; set; } = new(21, 0);
        public Field<long> Fletes { get; set; } = new(22, 0);
        public Field<long> Seguros { get; set; } = new(23, 0);
        public Field<long> Embalajes { get; set; } = new(24, 0);
        public Field<long> Otros { get; set; } = new(25, 0);
        public Field Origen_Mercancia { get; set; } = new(26, string.Empty);
        public Field Descargo_Mercancia { get; set; } = new(27, string.Empty);
        public Field Destino_Mercancia { get; set; } = new(28, string.Empty);
        public Field Codigo_Tipo_Bultos { get; set; } = new(29, string.Empty);
        public Field Tipo_Operacion { get; set; } = new(30, string.Empty);
        public Field Fecha_Expedicion { get; set; } = new(31, string.Empty);
        public Field Subdivision { get; set; } = new(32, string.Empty);
        public Field Certificado_Origen { get; set; } = new(33, string.Empty);
        public Field Observaciones { get; set; } = new(34, string.Empty);
        public Field eDocument { get; set; } = new(35, string.Empty);
        public Field Num_Referencia_Factura { get; set; } = new(36, string.Empty);
        public Field Clase_Aviso { get; set; } = new(37, string.Empty);
        public Field Tipo_Movimiento { get; set; } = new(38, string.Empty);
        public Field Enajenacion_Terminos_Articulo14CFF { get; set; } = new(39, string.Empty);
        public Field UUID { get; set; } = new(40, string.Empty);
        public Field Numero_Exportador_Autorizado { get; set; } = new(42, string.Empty);
        public Field<long> Fletes_Decrementables { get; set; } = new(43, 0);
        public Field Pais_Moneda_Fletes_Decrementables { get; set; } = new(44, string.Empty);
        public Field<long> Seguros_Decrementables { get; set; } = new(45, 0);
        public Field Pais_Moneda_Seguros_Decrementables { get; set; } = new(46, string.Empty);
        public Field<long> Carga_Decrementables { get; set; } = new(47, 0);
        public Field Pais_Moneda_Cargas_Decrementables { get; set; } = new(48, string.Empty);
        public Field<long> Descargas_Decrementables { get; set; } = new(49, 0);
        public Field Pais_Moneda_Descarga_Decrementables { get; set; } = new(50, string.Empty);
        public Field<long> Otros_Decrementables { get; set; } = new(51, 0);
        public Field Pais_Moneda_Otros_Decrementables { get; set; } = new(52, string.Empty);
    }
}
