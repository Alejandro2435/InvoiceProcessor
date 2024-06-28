using InvoiceProcessor.Models.Entities;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class CodigoImportador : Record
    {
        public CodigoImportador() : base("Codigo del Importador", "CCC", 51) { }
        public Field Numero_Cliente { get; set; } = new(1, string.Empty);
        public Field Nombre { get; set; } = new(2, string.Empty);
        public Field Apellido_Paterno { get; set; } = new(3, string.Empty);
        public Field Apellido_Materno { get; set; } = new(4, string.Empty);
        public Field Calle { get; set; } = new(5, string.Empty);
        public Field Numero_Interior { get; set; } = new(6, string.Empty);
        public Field Numero_Exterior { get; set; } = new(7, string.Empty);
        public Field Ciudad { get; set; } = new(8, string.Empty);
        public Field Codigo_Postal { get; set; } = new(9, string.Empty);
        public Field Estado { get; set; } = new(10, string.Empty);
        public Field Pais { get; set; } = new(11, string.Empty);
        public Field Entidad { get; set; } = new(12, string.Empty);
        public Field RFC { get; set; } = new(13, string.Empty);
        public Field CURP { get; set; } = new(14, string.Empty);
        public Field Tipo { get; set; } = new(15, string.Empty);
        public Field Proveedor { get; set; } = new(16, string.Empty);
        public Field Zona_Default { get; set; } = new(17, string.Empty);
        public Field Transporte_Arribo { get; set; } = new(18, string.Empty);
        public Field Transporte_Salida { get; set; } = new(19, string.Empty);
        public Field Transporte_Territorio { get; set; } = new(20, string.Empty);
        public Field Password { get; set; } = new(21, string.Empty);
        public Field Colonia { get; set; } = new(22, string.Empty);
        public Field Municipio { get; set; } = new(23, string.Empty);
        public Field Avisar_TLC { get; set; } = new(24, string.Empty);
        public Field Aplicar_TLC { get; set; } = new(25, string.Empty);
        public Field Desplegar_Precios_Estimados { get; set; } = new(26, string.Empty);
        public Field Desplegar_IEPS { get; set; } = new(27, string.Empty);
        public Field Aplicar_IEPS { get; set; } = new(28, string.Empty);
        public Field Preguntar_Azucar { get; set; } = new(29, string.Empty);
        public Field Revisar_SECOFI { get; set; } = new(30, string.Empty);
        public Field Desplegar_Avisos_Automaticos { get; set; } = new(31, string.Empty);
        public Field Desplegar_Notas_Extra { get; set; } = new(32, string.Empty);
        public Field Desplegar_Cuotas_Compensatorias { get; set; } = new(33, string.Empty);
        public Field Desplegar_Descripciones_Especificas { get; set; } = new(34, string.Empty);
        public Field Desplegar_NOMS { get; set; } = new(35, string.Empty);
        public Field Aplicar_NOMS { get; set; } = new(36, string.Empty);
        public Field Eximir_NOMS_Por { get; set; } = new(37, string.Empty);
        public Field Desplegar_Padron_Sectorial { get; set; } = new(38, string.Empty);
        public Field Desplegar_Aduanas_Autorizadas { get; set; } = new(39, string.Empty);
        public Field Desplegar_Permisos { get; set; } = new(40, string.Empty);
        public Field Desplegar_Etiquetas { get; set; } = new(41, string.Empty);
        public Field Aplicar_Etiquetado { get; set; } = new(42, string.Empty);
        public Field Eximir_Etiquetado { get; set; } = new(43, string.Empty);
        public Field Verificar_Peso { get; set; } = new(44, string.Empty);
        public Field Verificar_Valor_Comercial { get; set; } = new(45, string.Empty);
        public Field Uso_Mercancia { get; set; } = new(46, string.Empty);
        public Field Estado_Mercancia { get; set; } = new(47, string.Empty);
        public Field Metodo_Valoracion { get; set; } = new(48, string.Empty);
        public Field Vinculacion { get; set; } = new(49, string.Empty);
        public Field Campo_Extra { get; set; } = new(50, string.Empty);
    }
}
