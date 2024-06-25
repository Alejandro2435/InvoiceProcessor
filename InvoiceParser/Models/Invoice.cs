using System.Collections.Generic;

namespace InvoiceParser.Models
{
    public class Invoice
    {
        public string Name { get; set; } = string.Empty;
        public bool IsValid { get; set; } = true;
        public List<Record> Records { get; set; } = [];
        public List<string> Errors { get; set; } = [];
    }
}
