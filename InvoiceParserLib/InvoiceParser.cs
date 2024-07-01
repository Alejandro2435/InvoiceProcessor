using InvoiceProcessor.Models.Entities;
using InvoiceProcessor.Utils;
using System.Collections.Concurrent;
using static InvoiceProcessor.Utils.Enums;
using static InvoiceProcessor.Utils.Globals;

namespace InvoiceProcessor
{
    public class InvoiceParser
    {
        private readonly ICollection<(int, string)> _recordLines; 
        private readonly int _distributeFactor;

        public InvoiceParser(ICollection<(int, string)> recordLines, int distributeFactor = 1000)
        {
            _recordLines = recordLines;
            _distributeFactor = distributeFactor;
        }

        public static ICollection<Field> GetFields(string record)
        {
            ICollection<Field> fields = [];
            try
            {
                fields = record.Split((char)Separator.pipe).Select((field, index) => new Field(index, field)).ToList();
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
                    List< (int, string)> groupedRecordLines = _recordLines.ToList().GetRange(skip, take);
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

        private static Record ParseRecordLine((int,string) recordLine)
        {
            ICollection<Field> fields = GetFields(recordLine.Item2);
            Record record = null;
            try{
                string? recordType = fields.First(field => field.Index == 0)?.Value?.ToString();
                if (recordType.NotNull() && RecordEntities.TryGetValue(recordType, out var _record))
                {
                    _record.Content = recordLine.Item2;
                    _record.FileLine = recordLine.Item1;
                    _record.SetPropertyValues(fields.ToList());
                    record = _record;
                } 
            }
            catch(Exception ex)
            {
                Log(ex.Message);
            }
            return record;
        }

        private static async Task<List<Record>> GetRecordsAsync(List<(int,string)> recordLines)
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

        public async Task<Invoice> ParseAsync()
        {
            Invoice invoice = new();
            ConcurrentBag<Record> _records = [];
            try
            {
                List<ICollection<(int,string)>> recordLines = DistributeRecordLines();
                await Parallel.ForEachAsync(recordLines, async (recordLinesGroup, ct) =>
                {
                    List<Record> records = await GetRecordsAsync(recordLinesGroup.ToList());
                    Parallel.ForEach(records, (record, ct) => _records.Add(record));
                    //records.ForEach(recordLine => _records.Add(recordLine));
                    
                });
                invoice.Records = _records.ToList();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
            return await Task.FromResult(invoice);
        }
    }
}
