using InvoiceProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProcessor.Models.Entities
{
    public class Invoice
    {
        public string Name { get; set; } = string.Empty;
        public bool IsValid { get; set; } = true;
        public List<Record> Records { get; set; } = [];
    }
}
