using System;
using System.Collections.Generic;
using System.Linq;
using PAS.Properties;

namespace PAS
{
    public static partial class Methods
    {
        public static decimal GenerateCurrentPrice(DateTime currentDate)
        {
            var fromDateString = currentDate.AddDays(-30).ToString(Resources.DateFormat);
            var toDateStrong = currentDate.ToString(Resources.DateFormat);

            var records = Database.SelectRange("Prices", new[] { "Price" }, "Date", fromDateString, toDateStrong);
            var lastPrice = Decimal.Parse(records.Last().Last().ToString());
            var differences = new List<decimal>();

            for (var i = 0; i < 29; i++)
            {
                var todayPrice = Decimal.Parse(records[i].First().ToString());
                var tomorrowPrice = Decimal.Parse(records[i + 1].First().ToString());

                differences.Add(Math.Abs(todayPrice - tomorrowPrice));
            }

            var averageChangeInPrice = differences.Average();

            var rng = new Random();
            var currentRngNumber = rng.Next(1000);

            if (currentRngNumber > 250 && currentRngNumber < 500)
            {
                averageChangeInPrice += averageChangeInPrice * 0.1m;
            }
            else if (currentRngNumber > 500 && currentRngNumber < 750)
            {
                averageChangeInPrice -= averageChangeInPrice * 0.1m;
            }

            var currentPrice = currentRngNumber % 2 == 0
                ? lastPrice + averageChangeInPrice
                : lastPrice - averageChangeInPrice;

            Database.Insert("Prices", new Dictionary<string, object>
            {
                {"Date", currentDate.ToString(Resources.DateFormat)},
                {"Price", currentPrice}
            });

            return currentPrice;
        }
    }
}
