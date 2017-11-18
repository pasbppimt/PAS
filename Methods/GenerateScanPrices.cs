using System;
using System.Collections.Generic;

namespace PAS
{
    public static partial class Methods
    {
        public static void GenerateScanPrices(string date, decimal price)
        {
            var records = Database.Select("Prediction", new[] { "Price" }, new Dictionary<string, object> { { "Date", date } });

            if (records.Count > 0)
            {
                return;
            }

            var rng = new Random();
            var generatedRngNumber = rng.Next(1000);
            for (var scanLevel = 0; scanLevel <= 20; scanLevel++)
            {
                decimal currentPrice;
                if (scanLevel == 20)
                {
                    currentPrice = generatedRngNumber % 2 == 0
                        ? price + price * (rng.Next(1, 6) / 10000m)
                        : price - price * (rng.Next(1, 6) / 10000m);
                }
                else if (scanLevel >= 15)
                {
                    currentPrice = generatedRngNumber % 2 == 0
                        ? price + price * (rng.Next(5, 11) / 10000m)
                        : price - price * (rng.Next(5, 11) / 10000m);
                }
                else if (scanLevel >= 10)
                {
                    currentPrice = generatedRngNumber % 2 == 0
                        ? price + price * (rng.Next(10, 21) / 10000m)
                        : price - price * (rng.Next(10, 21) / 10000m);
                }
                else if (scanLevel >= 5)
                {
                    currentPrice = generatedRngNumber % 2 == 0
                        ? price + price * (rng.Next(20, 41) / 10000m)
                        : price - price * (rng.Next(20, 41) / 10000m);
                }
                else
                {
                    currentPrice = generatedRngNumber % 2 == 0
                        ? price + price * (rng.Next(40, 65) / 10000m)
                        : price - price * (rng.Next(40, 65) / 10000m);
                }

                Database.Insert("Prediction", new Dictionary<string, object>
                {
                    {"Date", date},
                    {"ScanLevel", scanLevel},
                    {"Price", currentPrice}
                });
            }
        }
    }
}
