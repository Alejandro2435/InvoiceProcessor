using InvoiceProcessor.Interfaces;
using System.ComponentModel.DataAnnotations;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor.Models.Entities
{
    public class Record : IInvoiceRecord
    {
        public Record(string name, string type, int fieldsCount, bool isUnique = false) 
        {
            Name = name;
            Type = new(0, type);
            FieldsCount = fieldsCount;
            IsUnique = isUnique;
        }
        public string Name { get; } = string.Empty;
        public Field Type { get; } = new(0, string.Empty);
        public string Content { get; set; } = string.Empty;
        public int FileLine { get; set; }
        public int FieldsCount { get; } = 0;
        public bool IsUnique { get; } = false;
        public List<string> Errors { get; set; } = [];
        public bool IsValid { get; set; } = true;
        public void SetPropertyValues(List<Field<string>> fields) {
            AssignPropertyValue(this, fields);
        }

        public void ValidateRecord()
        {
            try
            {
                ValidationContext validationContext = new(this, null, null);
                ICollection<ValidationResult> errors = [];
                IsValid = Validator.TryValidateObject(this, validationContext, errors, true);
                Errors.AddRange(errors.Select(error => error.ErrorMessage?? string.Empty).Where(error => !error.Equals(string.Empty)));
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }
    }
}
