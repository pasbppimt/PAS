using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace PAS
{
    public partial class MainForm
    {
        private void DrawChart(List<Tuple<DateTime, decimal>> entryList)
        {
            _dataTable.Rows.Clear();
            foreach (var entry in entryList)
            {
                _dataTable.Rows.Add(entry.Item1.ToString("dd-MM"), entry.Item2);
            }

            PredictionPriceLabel.Text = entryList.Last().Item2.ToString("C2");
            PredictionChartView.DataSource = _dataTable;

            PredictionChartView.ShowLegend = true;
            PredictionChartView.ChartElement.LegendPosition = LegendPosition.Top;

            PredictionChartView.Refresh();
        }

        private async Task<bool> FixDateTimePickers()
        {
            try
            {
                DateTime firstDate = DateTime.MinValue, lastDate = DateTime.MaxValue; //Initilized values are never used

                await Task.Run(() =>
                {
                    firstDate = DateTime.ParseExact(
                        Database.Select("Prices", new[] { "Date" }, new Dictionary<string, object> { { "Id", 1 } }).First()
                            .First().ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    lastDate = DateTime.ParseExact(
                        Database.Select("Prices", new[] { "Date" }, new Dictionary<string, object>
                                {{"Id", Database.SelectCount("Prices")}}).First()
                            .First().ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                });

                PredictionDateTimePicker.MinDate = firstDate;
                PredictionDateTimePicker.MaxDate = lastDate;
                PredictionDateTimePicker.Value = lastDate;

                DatabaseFromDateTimePicker.MinDate = firstDate;
                DatabaseFromDateTimePicker.MaxDate = lastDate;
                DatabaseFromDateTimePicker.Value = lastDate;

                DatabaseToDateTimePicker.MinDate = firstDate;
                DatabaseToDateTimePicker.MaxDate = lastDate;
                DatabaseToDateTimePicker.Value = lastDate;

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void FillDataGridView(List<Tuple<string, decimal>> recordList)
        {
            DatabaseGridView.Rows.Clear();

            for (int index = 0; index < recordList.Count; index++)
            {
                var date = recordList[index].Item1;
                var price = recordList[index].Item2.ToString("C2");
                string change;
                var color = DefaultForeColor;

                if (index == 0)
                {
                    change = 0m.ToString("C2");
                }
                else
                {
                    var changeIndecimal = (recordList[index].Item2 - recordList[index - 1].Item2);
                    var changeInDecimalAbs = Math.Abs(changeIndecimal);

                    if (changeIndecimal > 0m)
                    {
                        change = $"+ {changeInDecimalAbs:C2}";
                        color = ColorTranslator.FromHtml("#00C853");
                    }
                    else if (changeIndecimal < 0m)
                    {
                        change = $"- {changeInDecimalAbs:C2}";
                        color = ColorTranslator.FromHtml("#D50000");
                    }
                    else
                    {
                        change = 0m.ToString("C2");
                    }
                }

                DatabaseGridView.Rows.Add(date, price, change);
                DatabaseGridView.Rows.Last().Cells["DatabaseChangeColumn"].Style.ForeColor = color;
            }

            DatabaseGridView.ClearSelection();
            DatabaseGridView.Refresh();
        }
    }
}
