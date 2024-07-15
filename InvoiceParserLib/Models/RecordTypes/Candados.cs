using InvoiceProcessor.Models.Entities;
using InvoiceProcessor.Validations;
using System.ComponentModel.DataAnnotations;

namespace InvoiceProcessor.Models.RecordEntities
{
    public class Candados : Record
    {
        public Candados() : base("Candados", "516", 2) { }

        [MandatoryField(1,21, @"^[A-Za-z0-9|-]{1,21}$", ErrorMessage = "Es un campo requerido")]
        public Field Numero_Candado { get; set; } = new(1, string.Empty);
    }
}
