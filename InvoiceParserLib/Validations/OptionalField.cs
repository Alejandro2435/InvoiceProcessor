using InvoiceProcessor.Utils;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor.Validations
{
    internal class OptionalField : ValidationAttribute
    {
        private readonly int _maxStringLength, _minStringLength;
        private readonly string _regExp, _formatField;
        public OptionalField(int minStringLength, int maxStringLength, string regExp, string formatField)
        {
            _minStringLength = minStringLength;
            _maxStringLength = maxStringLength;
            _regExp = regExp;
            _formatField = formatField;
        }
        protected override ValidationResult IsValid(object value, ValidationContext valCtx)
        {
            string _value = value.ToString();
            string fieldName = valCtx.DisplayName.Replace('_', ' ');
            string errorMessageFormat = $"El campo {fieldName} es inválido ya que no se encuentra en el formato requerido: {_formatField}, valor actual: {value}";
            string errorMessageStringLength = $"El campo {fieldName} es inválido ya que no contiene los carácteres requeridos: {_maxStringLength}, carácteres actuales: {_value.Length}";
            try
            {
                if (_value.ToString().Equals(string.Empty))
                    return ValidationResult.Success;
                if (_value.Length.Between(_minStringLength, _maxStringLength))
                    if (_regExp != null)
                        return Regex.IsMatch(value.ToString(), _regExp) ? ValidationResult.Success : new ValidationResult(errorMessageFormat);
                    else
                        return ValidationResult.Success;
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            return new ValidationResult(errorMessageStringLength);
        }
    }
}
