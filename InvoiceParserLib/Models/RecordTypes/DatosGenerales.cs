using InvoiceProcessor.Models.Entities;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class DatosGenerales : Record
    {
        public DatosGenerales() : base("Datos Generales", "501", 36, true) { }

        public Field Tipo_Operacion { get; set; } = new(1, string.Empty);
        public Field Clave_Documento { get; set; } = new(2, string.Empty);
        public Field Numero_Pedimento { get; set; } = new(3, string.Empty);
        public Field Codigo_Importador { get; set; } = new(4, string.Empty);
        public Field<long> Fletes { get; set; } = new(5, 0);
        public Field<long> Seguros { get; set; } = new(6, 0);
        public Field<long> Embalajes { get; set; } = new(7, 0);
        public Field<long> Otros_Incrementables { get; set; } = new(8, 0);
        public Field<long> Otros_Deducibles { get; set; } = new(9, 0);
        public Field Peso_Bruto { get; set; } = new(10, string.Empty);
        public Field<long> Bultos { get; set; } = new(11, 0);
        public Field Transporte_Entrada_Salida { get; set; } = new(12, string.Empty);
        public Field Transporte_Arribo { get; set; } = new(13, string.Empty);
        public Field Transporte_Salida_Aduana { get; set; } = new(14, string.Empty);
        public Field Destino_o_Zona { get; set; } = new(15, string.Empty);
        public Field Referencia { get; set; } = new(16, string.Empty);
        public Field<int> Pesos { get; set; } = new(17, 0);
        public Field Tipo_Archivo { get; set; } = new(18, string.Empty);
        public Field Pais_Moneda { get; set; } = new(19, string.Empty);
        public Field Pais_Moneda_Fletes { get; set; } = new(20, string.Empty);
        public Field Pais_Moneda_Seguros { get; set; } = new(21, string.Empty);
        public Field Pais_Moneda_Embalajes { get; set; } = new(22, string.Empty);
        public Field Pais_Moneda_Otros_Incrementables { get; set; } = new(23, string.Empty);
        public Field Marcas_Numeros_Bultos { get; set; } = new(24, string.Empty);
        public Field Grupo_Factura { get; set; } = new(25, string.Empty);
        public Field<long> Fletes_Decrementables { get; set; } = new(26, 0);
        public Field Pais_Moneda_Fletes_Decrementables { get; set; } = new(27, string.Empty);
        public Field<long> Seguros_Decrementables { get; set; } = new(28, 0);
        public Field Pais_Moneda_Seguros_Decrementables { get; set; } = new(29, string.Empty);
        public Field<long> Carga_Decrementables { get; set; } = new(30, 0);
        public Field Pais_Moneda_Cargas_Decrementables { get; set; } = new(31, string.Empty);
        public Field<long> Descargas_Decrementables { get; set; } = new(32, 0);
        public Field Pais_Moneda_Descarga_Decrementables { get; set; } = new(33, string.Empty);
        public Field<long> Otros_Decrementables { get; set; } = new(34, 0);
        public Field Pais_Moneda_Otros_Decrementables { get; set; } = new(35, string.Empty);
    }
}
