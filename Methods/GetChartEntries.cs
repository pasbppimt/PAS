using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using PAS.Properties;

namespace PAS
{
    public static partial class Methods
    {
        public static List<Tuple<DateTime, decimal>> GetChartEntries(DateTime currentDate, int scanLevel, int daysCount = 30)
        {
            var dateAsString = currentDate.ToString(Resources.DateFormat);

            var currentPriceEntry = Database.Select("Prices", new[] { "Price" }, new Dictionary<string, object>
            {
                {
                    "Date", dateAsString
                }
            });

            var currentPrice = currentPriceEntry.Count == 0
                ? GenerateCurrentPrice(currentDate)
                : Decimal.Parse(currentPriceEntry.First().First().ToString());

            GenerateScanPrices(dateAsString, currentPrice);

            var fromDateString = currentDate.AddDays(-daysCount).ToString(Resources.DateFormat);
            var toDateStrong = currentDate.AddDays(-1).ToString(Resources.DateFormat);
            var records = Database.SelectRange("Prices", new[] { "Date", "Price" }, "Date", fromDateString, toDateStrong);

            var chartEntriesList = new List<Tuple<DateTime, decimal>>();
            foreach (var record in records)
            {
                var date = DateTime.ParseExact(record.First().ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                var price = Decimal.Round(Decimal.Parse(record.Last().ToString()), 2, MidpointRounding.AwayFromZero);

                chartEntriesList.Add(new Tuple<DateTime, decimal>(date, price));
            }

            var currentScanPriceString = Database.Select("Prediction", new[] { "Price" },
                new Dictionary<string, object>
                {
                    {"Date", dateAsString},
                    {"ScanLevel", scanLevel}
                }).First().First().ToString();

            var currentScanPrice = Decimal.Round(Decimal.Parse(currentScanPriceString), 2, MidpointRounding.AwayFromZero);

            chartEntriesList.Add(new Tuple<DateTime, decimal>(currentDate, currentScanPrice));

            return chartEntriesList;
        }
    }
}
