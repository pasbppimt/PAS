using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace PAS
{
    public partial class MainForm : RadForm
    {
        private readonly DataTable _dataTable = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            _dataTable.Columns.Add("x", typeof(string));
            _dataTable.Columns.Add("y", typeof(decimal));

            var lineSeries = new LineSeries();
            PredictionChartView.Series.Add(lineSeries);
            lineSeries.ValueMember = "y";
            lineSeries.CategoryMember = "x";
            lineSeries.Axes.First().LabelInterval = 5;
            lineSeries.Font = Font;
            lineSeries.LegendTitle = "INR Price for 10gm";
            lineSeries.IsVisibleInLegend = true;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RadMessageBox.ThemeName = "Material";
        }

        private async void MainForm_Initialized(object sender, EventArgs e)
        {
            await FixDateTimePickers();
        }

        private async void MainPageView_SelectedPageChanged(object sender, EventArgs e)
        {
            await FixDateTimePickers();
        }

        private async void PredictionPredictButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDate = PredictionDateTimePicker.Value;
                var scanLevel = Convert.ToInt32(PredictionScanTrackBar.Value);

                var chartEntries = Methods.GetChartEntries(selectedDate, scanLevel);

                var waitTime = Methods.GetWaitTime(scanLevel);

                PredictionPriceLabel.Text = string.Empty;

                PredictionWaitingBar.Visible = true;
                PredictionWaitingBar.ResetWaiting();
                PredictionWaitingBar.StartWaiting();
                PredictionGroupBox.Enabled = false;

                PredictionChartView.UseWaitCursor = true;
                await Task.Delay(waitTime * 1000);
                PredictionChartView.UseWaitCursor = false;

                PredictionWaitingBar.StopWaiting();
                PredictionWaitingBar.Visible = false;
                PredictionGroupBox.Enabled = true;

                DrawChart(chartEntries);
            }
            catch (Exception exception)
            {
                var msg = exception.Message;

                if (msg.Contains("Sequence contains no elements"))
                {
                    msg = "Cannot compute due to insufficient data!";
                }

                PredictionPriceLabel.Text = msg;
                PredictionPriceLabel.ForeColor = ColorTranslator.FromHtml("#F44336");

                await Task.Delay(5000);

                PredictionPriceLabel.Text = string.Empty;
                PredictionPriceLabel.ForeColor = DefaultForeColor;
            }
        }

        private async void DatabasePricesButton_Click(object sender, EventArgs e)
        {
            try
            {
                var fromDateString = DatabaseFromDateTimePicker.Value.ToString("yyyy-MM-dd");
                var toDateString = DatabaseToDateTimePicker.Value.ToString("yyyy-MM-dd");
                var exportPath = string.Empty;

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV (*.csv)|*.csv";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        exportPath = saveFileDialog.FileName;
                    }
                }

                var fillGridViewCheck = RadMessageBox.Show(this, "Load to UI data table?", "Confirm", MessageBoxButtons.YesNoCancel,
                    RadMessageIcon.Question);

                var recordList = await Methods.SaveRecordsToDisk(fromDateString, toDateString, exportPath);

                if (fillGridViewCheck == DialogResult.Yes)
                {
                    FillDataGridView(recordList);
                }
                
                if (!string.IsNullOrEmpty(exportPath))
                {
                    RadMessageBox.Show(this, "All records exported successfully!", "Success", MessageBoxButtons.OK,
                        RadMessageIcon.Info);
                }           
            }
            catch
            {
                const string errorMessage = "An error occurred when trying to export the data!";
                RadMessageBox.Show(this, errorMessage, "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }
    }
}
