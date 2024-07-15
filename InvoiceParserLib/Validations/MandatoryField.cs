using InvoiceProcessor.Models.Entities;
using InvoiceProcessor.Utils;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor.Validations
{
    public class MandatoryField : ValidationAttribute
    {
        private readonly int _minStringLength, _maxStringLength;
        private readonly string _regExp;

        public MandatoryField(int minStringLength, int maxStringLength, string regExp)
        {
            _minStringLength = minStringLength;
            _maxStringLength = maxStringLength;
            _regExp = regExp;
        }

        protected override ValidationResult IsValid(object value, ValidationContext valCtx)
        {
            try
            {
                Field? field = value as Field;
                if(!field.NotNull()) {
                    return new($"La propiedad no es del tipo Field o Field<T>");
                }
                Type fieldType = field.GetType();
                Type fieldValueType = field.Value.GetType();
                if (fieldType.IsGenericType && fieldType.GenericTypeArguments[0] == fieldType)
                {
                    return new($"El valor de la propiedad es distinto al declarado en el modelo");
                }
                var fieldValue = Convert.ChangeType(field.Value, fieldValueType);
                if (!fieldValue.NotNull())
                {
                    return new($"El valor asignado al campo {valCtx.DisplayName} en el índice {field.Index} no se puede convertir al tipo declarado en el modelo");
                }

                return ValidationResult.Success;
            }catch (Exception ex) {
                Log(ex.Message);
                return new(ex.Message);
            }
            //string _value = value.ToString();
            //string fieldName = valCtx.DisplayName.Replace('_', ' ');
            //string errorMessageHasNoValue = $"{HeadErrorMessageField}{fieldName}{ErrorRequiredField}.";
            //string errorMessageFormat = $"El campo {fieldName} es inválido ya que no se encuentra en el formato requerido: {_formatField}, valor actual: {value}";
            //string errorMessageStringLength = $"El campo {fieldName} es inválido ya que no contiene los carácteres requeridos: {_maxStringLength}, carácteres actuales: {_value.Length}";
            //try
            //{
            //    if (_value.ToString().Equals(string.Empty))
            //        return new ValidationResult(errorMessageHasNoValue);
            //    if (_value.Length.Between(_minStringLength, _maxStringLength))
            //        if (_regExp != null)
            //            return Regex.IsMatch(value.ToString(), _regExp) ? ValidationResult.Success : new ValidationResult(errorMessageFormat);
            //        else
            //            return ValidationResult.Success;
            //}
            //catch (Exception ex)
            //{
            //    Log(ex.Message);
            //}
            //return new ValidationResult(errorMessageStringLength);
        }
    }
}
