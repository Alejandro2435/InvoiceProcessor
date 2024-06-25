using InvoiceParserLib.Interfaces;
using InvoiceParserLib.Models.Entities;
using InvoiceParserLib.Utils;
using System.Collections.Concurrent;
using System.Text;
using static InvoiceParserLib.Utils.Enums;
using static InvoiceParserLib.Utils.Globals;

namespace InvoiceParserLib
{
    public class InvoiceParser
    {
        private readonly string _invoice = string.Empty;
        private  readonly OriginOfInvoiceContent _originOfInvoiceContent = OriginOfInvoiceContent.FromFilePath;
        
        public InvoiceParser(string invoiceTXT, OriginOfInvoiceContent originOfInvoiceContent = OriginOfInvoiceContent.FromFilePath) 
        { 
            _invoice = invoiceTXT;
            _originOfInvoiceContent = originOfInvoiceContent;
        }

        private List<Field> GetFields(string record)
        {
            List<Field> fields;
            try
            {
               fields = record.Split((char)Separator.pipe).Select((field, index) => new Field(index, field)).ToList();
            }catch (Exception ex)
            {
                Log(ex.Message);
                fields = [];
            }
            return fields;
        }

        private async Task<List<Record>> GetRecords() 
        {
            List<string> recordLines;
            ConcurrentBag<Record> records = [];
            try{
                if (_originOfInvoiceContent == OriginOfInvoiceContent.FromFilePath)
                    recordLines = File.ReadAllLines(_invoice, Encoding.UTF8).ToList();
                else
                    recordLines = _invoice.Split(Environment.NewLine.ToCharArray()).ToList();

                ParallelOptions parallelOptions = new()
                {
                    MaxDegreeOfParallelism = 5
                };
                ConcurrentBag<Record> result = [];
                await Parallel.ForEachAsync(recordLines, parallelOptions, (recordLine, cancelToken) =>
                {
                    List<Field> fields = GetFields(recordLine);
                    string? recordType = fields.First(field => field.Index == 0)?.Value?.ToString();
                    if (recordType.NotNull() && RecordEntities.TryGetValue(recordType, out var record))
                    {
                        record.SetPropertyValues(fields);
                        records.Add(record);
                    }
                    return ValueTask.CompletedTask;
                });
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            return records.ToList();
        }

        private static List<List<string>> DistributeRecords(List<string> invoiceRecords)
        {
            List<List<string>> records = [];
            try
            {
                records = invoiceRecords.
                    Select((val, idx) => new { Index = idx, Value = val })
                    .GroupBy(val => val.Index / 100)
                    .Select(val => val.Select(v => v.Value).ToList())
                    .ToList();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            return records;
        }

        public async Task<Invoice> ParseAsync()
        {
            Invoice invoice = new();
            try
            {
                invoice.Name = _invoice.Split('\\').ToList().Last().ToString();
                invoice.Records = await GetRecords();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            return invoice;
        }
    }
}
