using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceParserLib.Models.Entities
{
    public class Field<T>(int index, T value )
    {
        public int Index { get; } = index;
        public T Value { get; set; } = value;
    }
    public class Field(int index, object value) : Field<object>(index, value) { }
}
