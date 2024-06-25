using InvoiceParserLib.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InvoiceParserLib.Utils.Enums;

namespace InvoiceParserLib.Interfaces
{
    public interface IInvoiceRecord
    {
        string Name { get; }
        string Type { get ; }
        string Content { get; set; }
        int FileLine { get; set; }
        int FieldsCount {  get; }
        void SetPropertyValues(List<Field> fields);
    }
}
