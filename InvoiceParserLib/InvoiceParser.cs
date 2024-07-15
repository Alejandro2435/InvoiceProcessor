using InvoiceProcessor.Models.Entities;
using InvoiceProcessor.Utils;
using System.Collections.Concurrent;
using System.Diagnostics;
using static InvoiceProcessor.Utils.Enums;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor
{
    public class InvoiceParser(ICollection<(int, string)> recordLines, int distributeFactor = 1000)
    {
        private readonly ICollection<(int, string)> _recordLines = recordLines; 
        private readonly int _distributeFactor = distributeFactor;

        public static ICollection<Field<string>> GetFields(string record)
        {
            Stopwatch sw = Stopwatch.StartNew();
            ICollection<Field<string>> fields = [];
            try
            {
                fields = record.Split((char)Separator.pipe).Select((field, index) => new Field<string>(index, field)).ToList();
            } catch (Exception ex)
            {
                Log(ex.Message);
            }
            return fields;
        }

        private List<ICollection<(int, string)>> DistributeRecordLines()
        {
            List<ICollection<(int, string)>> records = [];
            int groupsCount = (int)Math.Floor((decimal)_recordLines.Count / _distributeFactor);
            try
            {
                for(int i = 0; i < groupsCount; i++)
                {
                    int skip = i * _distributeFactor;
                    int take = _distributeFactor;
                    List<(int, string)> groupedRecordLines = _recordLines.ToList().GetRange(skip, take);
                    records.Add(groupedRecordLines);
                }
                int maxGroupNumber = _distributeFactor * groupsCount;
                records.Add(_recordLines.ToList().GetRange(maxGroupNumber, _recordLines.Count - maxGroupNumber));
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            return records;
        }

        public static Record? ParseRecordLine((int,string) recordLine)
        {
            ICollection<Field<string>> fields = GetFields(recordLine.Item2);
            Stopwatch sw = Stopwatch.StartNew();
            Record? record = null;
            try{
                string? recordType = fields.First(field => field.Index == 0)?.Value?.ToString();
                if (recordType.NotNull() && RecordEntities.TryGetValue(recordType, out var _record))
                {
                    _record.Content = recordLine.Item2;
                    _record.FileLine = recordLine.Item1;
                    _record.SetPropertyValues(fields.ToList());
                    _record.ValidateRecord();
                    record = _record;
                } 
            }
            catch(Exception ex)
            {
                Log(ex.Message);
            }
            return record;
        }

        public static List<Record?> GetRecords(List<(int,string)> recordLines)
        {
            Stopwatch sw = Stopwatch.StartNew();
            List<Record?> records = [];
            try
            {
                records = recordLines.AsParallel().Select(ParseRecordLine).Where(record => record.NotNull()).ToList();
            }
            catch(Exception ex) 
            { 
                Log(ex.Message);
            }
            return records;
        }

        public async Task<Invoice> ParseAsync()
        {
            Invoice invoice = new();
            ConcurrentBag<Record?> _records = [];
            try
            {
                List<ICollection<(int, string)>> distributedLines = DistributeRecordLines();
                await Parallel.ForEachAsync(distributedLines, async (lines, cancelToken) =>
                {
                    await Task.Run(() =>
                    {
                        List<Record?> records = GetRecords(lines.ToList());
                        Parallel.ForEach(records, record => _records.Add(record));
                    }, cancelToken);
                });
                invoice.Records = _records.ToList();
                invoice.IsValid = _records.AsParallel().All(record => record.IsValid);
            }
            catch(Exception ex)
            {
                Log(ex.Message);
            }

            return invoice;
        }
    }
}
