using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceParser.Models.Interfaces
{
    public interface IInvoiceRecord
    {
        string Name { get; set; }
        string Type { get; set; }
        string Content { get; set; }
        List<Field> Fields { get; set; }
        int FileLine { get; set; }
        int Min_Fields_Required { get; set; }

        List<Field> GetFields(string record, string separator = "|");
    }
}
