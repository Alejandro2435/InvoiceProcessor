using InvoiceProcessor.Interfaces;
using InvoiceProcessor.Models.Entities;
using InvoiceProcessor.Utils;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;
using static InvoiceProcessor.Utils.Enums;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor
{
    public class InvoiceParser
    {
        private readonly string _invoice = string.Empty;
        private readonly OriginOfInvoiceContent _originOfInvoiceContent = OriginOfInvoiceContent.FromFilePath;
        private readonly int _distributeFactor;

        public InvoiceParser(string invoiceTXT, OriginOfInvoiceContent originOfInvoiceContent = OriginOfInvoiceContent.FromFilePath, int distributeFactor = 1000)
        {
            _invoice = invoiceTXT;
            _originOfInvoiceContent = originOfInvoiceContent;
            _distributeFactor = distributeFactor;
        }

        private List<string> GetRecordLines() 
        {
            List<string> recordLines = [];
            try
            {
                if (_originOfInvoiceContent == OriginOfInvoiceContent.FromFilePath)
                    recordLines = File.ReadAllLines(_invoice, Encoding.UTF8).ToList();
                else
                    recordLines = _invoice.Split(Environment.NewLine.ToCharArray()).ToList();
            }
            catch(Exception ex) 
            {
                Log(ex.Message);
            }
            return recordLines;
        }

        public static List<Field> GetFields(string record)
        {
            List<Field> fields;
            try
            {
                fields = record.Split((char)Separator.pipe).Select((field, index) => new Field(index, field)).ToList();
            } catch (Exception ex)
            {
                Log(ex.Message);
                fields = [];
            }
            return fields;
        }

        private List<List<string>> DistributeRecordLines(List<string> invoiceRecords)
        {
            List<List<string>> records = [];
            try
            {
                records = invoiceRecords.
                    Select((val, idx) => new { Index = idx, Value = val })
                    .GroupBy(val => val.Index / _distributeFactor)
                    .Select(val => val.Select(v => v.Value).ToList())
                    .ToList();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            return records;
        }

        private static Record ParseRecordLine(string recordLine)
        {
            List<Field> fields = GetFields(recordLine);
            Record record = null;
            string? recordType = fields.First(field => field.Index == 0)?.Value?.ToString();
            if (recordType.NotNull() && RecordEntities.TryGetValue(recordType, out var _record))
            {
                _record.Content = recordLine;
                _record.SetPropertyValues(fields);
                record = _record;
            }
            return record;
        }

        private static async Task<List<Record>> GetRecordsAsync(List<string> recordLines)
        {
            Task<List<Record>> getRecordsTask = null;
            List<Record> records = [];
            try
            {
                getRecordsTask = Task.Run(() => {
                    records = recordLines.Select(recordLine => ParseRecordLine(recordLine)).ToList();
                    return records;
                });
            }
            catch(Exception ex) 
            { 
                Log(ex.Message);
            }
            return await getRecordsTask;
        }

        //private Task<List<Record>> GetRecordss(List<string> recordLines)
        //{
        //    //List<Task<List<Record>>> parsingRecordsTasks = [];
        //    //Task<List<Record>> parsingRecordsTask = null;
        //    //ConcurrentBag<Record> records = [];
        //    //try{
        //    //    if (_originOfInvoiceContent == OriginOfInvoiceContent.FromFilePath)
        //    //        recordLines = File.ReadAllLines(_invoice, Encoding.UTF8).ToList();
        //    //    else
        //    //        recordLines = _invoice.Split(Environment.NewLine.ToCharArray()).ToList();

        //    //    List<List<string>> distributedRecordLines = DistributeRecords(recordLines);
        //    //    //ConcurrentBag<Record> result = [];
        //    //    //parsingRecordsTasks = distributedRecordLines.Select(recordLinesGroup => Task.Run(() => {
        //    //    //        List<Record> records = recordLines.Select(recordLine => ParseRecordLine(recordLine)).ToList();
        //    //    //        return records;
        //    //    //    })
        //    //    //).ToList();
        //    //    parsingRecordsTask = Task.Run(() =>
        //    //    {
        //    //        distributedRecordLines.ForEach(async recordLinesGroup =>
        //    //        {
        //    //            Task<List<Record>> parseRecordLineTask = Task.Run(() =>
        //    //            {
        //    //                recordLinesGroup.ForEach(recordLine => {
        //    //                    Record record = ParseRecordLine(recordLine);
        //    //                    records.Add(record);
        //    //                });
        //    //                return records.ToList();
        //    //            });
        //    //        });
        //    //        return parsingRecordsTask;
        //    //    });
              
        //    //    //await Parallel.ForEachAsync(distributedRecordLines, (_recordLines, cancelToken) =>
        //    //    //{
        //    //    //    List<Task<Record>> r = Task.Run(() => {
        //    //    //        _recordLines.ForEach(recordLine =>
        //    //    //        {
        //    //    //            List<Field> fields = GetFields(recordLine);
        //    //    //            string? recordType = fields.First(field => field.Index == 0)?.Value?.ToString();
        //    //    //            if (recordType.NotNull() && RecordEntities.TryGetValue(recordType, out var record))
        //    //    //            {
        //    //    //                record.Content = recordLine;
        //    //    //                record.SetPropertyValues(fields);
        //    //    //                records.Add(record);
        //    //    //            }
        //    //    //        });
        //    //    //    });
        //    //    //    return Task.WhenAll(r).Result;
        //    //    //});
        //    //    //await Parallel.ForEachAsync(recordLines, (recordLine, cancelToken) =>
        //    //    //{
        //    //    //    List<Field> fields = GetFields(recordLine);
        //    //    //    string? recordType = fields.First(field => field.Index == 0)?.Value?.ToString();
        //    //    //    if (recordType.NotNull() && RecordEntities.TryGetValue(recordType, out var record))
        //    //    //    {
        //    //    //        record.Content = recordLine;
        //    //    //        record.SetPropertyValues(fields);
        //    //    //        records.Add(record);
        //    //    //    }
        //    //    //    return ValueTask.CompletedTask;
        //    //    //});
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    Log(ex.Message);
        //    //}
        //    //return parsingRecordsTask;
        //    //return records.ToList();
        //}

        public async Task<Invoice> ParseAsync()
        {
            Invoice invoice = new();
            List<Record> records = [];
            List<Task<List<Record>>> parsingRecordsTaskList = [];
            try
            {
                List<List<string>> recordLines = DistributeRecordLines(GetRecordLines());
                recordLines.ForEach(async recordLinesGroup =>
                {
                    Task<List<Record>> parseRecordLinesTask = GetRecordsAsync(recordLinesGroup);
                    parsingRecordsTaskList.Add(parseRecordLinesTask);
                    records.AddRange(await Task.FromResult(parseRecordLinesTask).Result);
                });
                await Task.WhenAll(parsingRecordsTaskList);

                invoice.Name = _invoice.Split('\\').ToList().Last().ToString();

                invoice.Records = records;
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            return await Task.FromResult(invoice);
        }
    }
}
