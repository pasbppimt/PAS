using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;

namespace PAS
{
    public static partial class Methods
    {
        public static async Task<List<Tuple<string, decimal>>> SaveRecordsToDisk(string fromDateString, string toDateString, string exportPath)
        {
            var recordList = new List<Tuple<string, decimal>>();

            await Task.Run(() =>
            {
                var recordsFromDb = Database.SelectRange("Prices", new[] { "Date", "Price" }, "Date", fromDateString,
                    toDateString);
                recordList = recordsFromDb.Select(record => new { record, dateString = record.First().ToString() })
                    .Select(t => new { t, decimalPrice = Decimal.Parse(t.record.Last().ToString()) })
                    .Select(t => new Tuple<string, decimal>(t.t.dateString, t.decimalPrice)).ToList();
            });

            if (!String.IsNullOrEmpty(exportPath))
            {
                using (var streamWriter = new StreamWriter(exportPath))
                using (var csvWriter = new CsvWriter(streamWriter))
                {
                    var objectList = new List<object>();
                    foreach (var record in recordList)
                    {
                        objectList.Add(new
                        {
                            Date = record.Item1,
                            Price = record.Item2
                        });
                    }

                    csvWriter.WriteRecords(objectList);
                }
            }

            return recordList;
        }

        public static int GetWaitTime(int scanLevel)
        {
            var waitTime = scanLevel;

            if (scanLevel < 5)
            {
                waitTime = waitTime * 2;
            }
            else if (scanLevel < 10)
            {
                waitTime = 2 * (waitTime + 10);
            }
            else if (scanLevel < 15)
            {
                waitTime = 3 * (waitTime + 15);
            }
            else
            {
                waitTime = 5 * (waitTime + 20);
            }

            return waitTime;
        }
    }
}