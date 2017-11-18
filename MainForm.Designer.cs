using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace PAS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MatTheme = new Telerik.WinControls.Themes.MaterialTheme();
            this.MainPageView = new Telerik.WinControls.UI.RadPageView();
            this.LivePredictionPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.PredictionPriceLabel = new Telerik.WinControls.UI.RadLabelElement();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PredictionChartView = new Telerik.WinControls.UI.RadChartView();
            this.PredictionWaitingBar = new Telerik.WinControls.UI.RadWaitingBar();
            this.dotsSpinnerWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.DotsSpinnerWaitingBarIndicatorElement();
            this.PredictionGroupBox = new System.Windows.Forms.GroupBox();
            this.PredictionScanTrackBar = new Telerik.WinControls.UI.RadTrackBar();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.PredictionDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.PredictionPredictButton = new Telerik.WinControls.UI.RadButton();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.DatabaseGridView = new Telerik.WinControls.UI.RadGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DatabaseToDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.DatabaseFromDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            this.DatabasePricesButton = new Telerik.WinControls.UI.RadButton();
            this.AboutPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.radStatusStrip2 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageView)).BeginInit();
            this.MainPageView.SuspendLayout();
            this.LivePredictionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionChartView)).BeginInit();
            this.PredictionChartView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionWaitingBar)).BeginInit();
            this.PredictionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionScanTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionPredictButton)).BeginInit();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGridView.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseToDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFromDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasePricesButton)).BeginInit();
            this.AboutPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPageView
            // 
            this.MainPageView.Controls.Add(this.LivePredictionPage);
            this.MainPageView.Controls.Add(this.radPageViewPage1);
            this.MainPageView.Controls.Add(this.AboutPage);
            this.MainPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageView.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MainPageView.Location = new System.Drawing.Point(0, 0);
            this.MainPageView.Name = "MainPageView";
            this.MainPageView.SelectedPage = this.LivePredictionPage;
            this.MainPageView.Size = new System.Drawing.Size(785, 643);
            this.MainPageView.TabIndex = 0;
            this.MainPageView.Text = "radPageView1";
            this.MainPageView.ThemeName = "Material";
            this.MainPageView.SelectedPageChanged += new System.EventHandler(this.MainPageView_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.MainPageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // LivePredictionPage
            // 
            this.LivePredictionPage.Controls.Add(this.radStatusStrip1);
            this.LivePredictionPage.Controls.Add(this.groupBox2);
            this.LivePredictionPage.Controls.Add(this.PredictionGroupBox);
            this.LivePredictionPage.ItemSize = new System.Drawing.SizeF(122F, 50F);
            this.LivePredictionPage.Location = new System.Drawing.Point(6, 56);
            this.LivePredictionPage.Name = "LivePredictionPage";
            this.LivePredictionPage.Size = new System.Drawing.Size(773, 581);
            this.LivePredictionPage.Text = "Live Prediction";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.PredictionPriceLabel});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 556);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(773, 25);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 2;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "Material";
            // 
            // PredictionPriceLabel
            // 
            this.PredictionPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.PredictionPriceLabel.Name = "PredictionPriceLabel";
            this.radStatusStrip1.SetSpring(this.PredictionPriceLabel, true);
            this.PredictionPriceLabel.Text = "";
            this.PredictionPriceLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PredictionPriceLabel.TextWrap = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PredictionChartView);
            this.groupBox2.Location = new System.Drawing.Point(6, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chart";
            // 
            // PredictionChartView
            // 
            this.PredictionChartView.AreaDesign = cartesianArea1;
            this.PredictionChartView.Controls.Add(this.PredictionWaitingBar);
            this.PredictionChartView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredictionChartView.Location = new System.Drawing.Point(3, 22);
            this.PredictionChartView.Name = "PredictionChartView";
            this.PredictionChartView.SelectionMode = Telerik.WinControls.UI.ChartSelectionMode.SingleDataPoint;
            this.PredictionChartView.ShowGrid = false;
            this.PredictionChartView.ShowPanZoom = true;
            this.PredictionChartView.ShowTrackBall = true;
            this.PredictionChartView.Size = new System.Drawing.Size(741, 272);
            this.PredictionChartView.TabIndex = 0;
            this.PredictionChartView.Text = "radChartView1";
            this.PredictionChartView.ThemeName = "Material";
            // 
            // PredictionWaitingBar
            // 
            this.PredictionWaitingBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredictionWaitingBar.Location = new System.Drawing.Point(0, 0);
            this.PredictionWaitingBar.Name = "PredictionWaitingBar";
            this.PredictionWaitingBar.Size = new System.Drawing.Size(741, 272);
            this.PredictionWaitingBar.TabIndex = 0;
            this.PredictionWaitingBar.ThemeName = "ControlDefault";
            this.PredictionWaitingBar.WaitingIndicators.Add(this.dotsSpinnerWaitingBarIndicatorElement1);
            this.PredictionWaitingBar.WaitingSpeed = 100;
            this.PredictionWaitingBar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsSpinner;
            // 
            // dotsSpinnerWaitingBarIndicatorElement1
            // 
            this.dotsSpinnerWaitingBarIndicatorElement1.Name = "dotsSpinnerWaitingBarIndicatorElement1";
            // 
            // PredictionGroupBox
            // 
            this.PredictionGroupBox.Controls.Add(this.PredictionScanTrackBar);
            this.PredictionGroupBox.Controls.Add(this.radLabel1);
            this.PredictionGroupBox.Controls.Add(this.PredictionDateTimePicker);
            this.PredictionGroupBox.Controls.Add(this.PredictionPredictButton);
            this.PredictionGroupBox.Location = new System.Drawing.Point(6, 3);
            this.PredictionGroupBox.Name = "PredictionGroupBox";
            this.PredictionGroupBox.Size = new System.Drawing.Size(747, 234);
            this.PredictionGroupBox.TabIndex = 0;
            this.PredictionGroupBox.TabStop = false;
            this.PredictionGroupBox.Text = "Prediction";
            // 
            // PredictionScanTrackBar
            // 
            this.PredictionScanTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PredictionScanTrackBar.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PredictionScanTrackBar.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.TopLeft;
            this.PredictionScanTrackBar.Location = new System.Drawing.Point(6, 97);
            this.PredictionScanTrackBar.Name = "PredictionScanTrackBar";
            this.PredictionScanTrackBar.Size = new System.Drawing.Size(735, 68);
            this.PredictionScanTrackBar.TabIndex = 4;
            this.PredictionScanTrackBar.ThemeName = "Material";
            this.PredictionScanTrackBar.ThumbSize = new System.Drawing.Size(15, 15);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.radLabel1.Location = new System.Drawing.Point(6, 69);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(540, 22);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Scan Level: (Higher level indiciates deeper data mining but more time consumption" +
    ")";
            // 
            // PredictionDateTimePicker
            // 
            this.PredictionDateTimePicker.CalendarSize = new System.Drawing.Size(290, 320);
            this.PredictionDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PredictionDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PredictionDateTimePicker.Location = new System.Drawing.Point(6, 25);
            this.PredictionDateTimePicker.Name = "PredictionDateTimePicker";
            this.PredictionDateTimePicker.Size = new System.Drawing.Size(283, 38);
            this.PredictionDateTimePicker.TabIndex = 1;
            this.PredictionDateTimePicker.TabStop = false;
            this.PredictionDateTimePicker.Text = "25 October 2017";
            this.PredictionDateTimePicker.ThemeName = "Material";
            this.PredictionDateTimePicker.Value = new System.DateTime(2017, 10, 25, 19, 43, 15, 516);
            // 
            // PredictionPredictButton
            // 
            this.PredictionPredictButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PredictionPredictButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PredictionPredictButton.Location = new System.Drawing.Point(6, 192);
            this.PredictionPredictButton.Name = "PredictionPredictButton";
            this.PredictionPredictButton.Size = new System.Drawing.Size(120, 36);
            this.PredictionPredictButton.TabIndex = 0;
            this.PredictionPredictButton.Text = "Predict";
            this.PredictionPredictButton.ThemeName = "Material";
            this.PredictionPredictButton.Click += new System.EventHandler(this.PredictionPredictButton_Click);
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.DatabaseGridView);
            this.radPageViewPage1.Controls.Add(this.groupBox1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(88F, 50F);
            this.radPageViewPage1.Location = new System.Drawing.Point(6, 56);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(773, 581);
            this.radPageViewPage1.Text = "Database";
            // 
            // DatabaseGridView
            // 
            this.DatabaseGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DatabaseGridView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatabaseGridView.Location = new System.Drawing.Point(0, 129);
            // 
            // 
            // 
            this.DatabaseGridView.MasterTemplate.AllowAddNewRow = false;
            this.DatabaseGridView.MasterTemplate.AllowDeleteRow = false;
            this.DatabaseGridView.MasterTemplate.AllowRowResize = false;
            this.DatabaseGridView.MasterTemplate.AllowSearchRow = true;
            this.DatabaseGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "Date";
            gridViewTextBoxColumn1.Name = "DatabaseDateColumn";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 241;
            gridViewTextBoxColumn2.HeaderText = "Price";
            gridViewTextBoxColumn2.Name = "DatabasePriceColumn";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 241;
            gridViewTextBoxColumn3.HeaderText = "Change";
            gridViewTextBoxColumn3.Name = "DatabaseChangeColumn";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 243;
            this.DatabaseGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.DatabaseGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DatabaseGridView.Name = "DatabaseGridView";
            this.DatabaseGridView.ReadOnly = true;
            this.DatabaseGridView.ShowGroupPanel = false;
            this.DatabaseGridView.Size = new System.Drawing.Size(773, 452);
            this.DatabaseGridView.TabIndex = 2;
            this.DatabaseGridView.Text = "radGridView1";
            this.DatabaseGridView.ThemeName = "Material";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatabaseToDateTimePicker);
            this.groupBox1.Controls.Add(this.DatabaseFromDateTimePicker);
            this.groupBox1.Controls.Add(this.DatabasePricesButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Setting";
            // 
            // DatabaseToDateTimePicker
            // 
            this.DatabaseToDateTimePicker.CalendarSize = new System.Drawing.Size(290, 320);
            this.DatabaseToDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatabaseToDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DatabaseToDateTimePicker.Location = new System.Drawing.Point(295, 25);
            this.DatabaseToDateTimePicker.Name = "DatabaseToDateTimePicker";
            this.DatabaseToDateTimePicker.Size = new System.Drawing.Size(283, 38);
            this.DatabaseToDateTimePicker.TabIndex = 2;
            this.DatabaseToDateTimePicker.TabStop = false;
            this.DatabaseToDateTimePicker.Text = "25 October 2017";
            this.DatabaseToDateTimePicker.ThemeName = "Material";
            this.DatabaseToDateTimePicker.Value = new System.DateTime(2017, 10, 25, 19, 43, 15, 516);
            // 
            // DatabaseFromDateTimePicker
            // 
            this.DatabaseFromDateTimePicker.CalendarSize = new System.Drawing.Size(290, 320);
            this.DatabaseFromDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatabaseFromDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DatabaseFromDateTimePicker.Location = new System.Drawing.Point(6, 25);
            this.DatabaseFromDateTimePicker.Name = "DatabaseFromDateTimePicker";
            this.DatabaseFromDateTimePicker.Size = new System.Drawing.Size(283, 38);
            this.DatabaseFromDateTimePicker.TabIndex = 1;
            this.DatabaseFromDateTimePicker.TabStop = false;
            this.DatabaseFromDateTimePicker.Text = "25 October 2017";
            this.DatabaseFromDateTimePicker.ThemeName = "Material";
            this.DatabaseFromDateTimePicker.Value = new System.DateTime(2017, 10, 25, 19, 43, 15, 516);
            // 
            // DatabasePricesButton
            // 
            this.DatabasePricesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatabasePricesButton.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DatabasePricesButton.Location = new System.Drawing.Point(6, 69);
            this.DatabasePricesButton.Name = "DatabasePricesButton";
            this.DatabasePricesButton.Size = new System.Drawing.Size(133, 36);
            this.DatabasePricesButton.TabIndex = 0;
            this.DatabasePricesButton.Text = "Export Prices";
            this.DatabasePricesButton.ThemeName = "Material";
            this.DatabasePricesButton.Click += new System.EventHandler(this.DatabasePricesButton_Click);
            // 
            // AboutPage
            // 
            this.AboutPage.Controls.Add(this.radStatusStrip2);
            this.AboutPage.Controls.Add(this.radGroupBox1);
            this.AboutPage.ItemSize = new System.Drawing.SizeF(68F, 50F);
            this.AboutPage.Location = new System.Drawing.Point(6, 56);
            this.AboutPage.Name = "AboutPage";
            this.AboutPage.Size = new System.Drawing.Size(761, 575);
            this.AboutPage.Text = "About";
            // 
            // radStatusStrip2
            // 
            this.radStatusStrip2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1});
            this.radStatusStrip2.Location = new System.Drawing.Point(0, 575);
            this.radStatusStrip2.Name = "radStatusStrip2";
            this.radStatusStrip2.Size = new System.Drawing.Size(761, 0);
            this.radStatusStrip2.SizingGrip = false;
            this.radStatusStrip2.TabIndex = 3;
            this.radStatusStrip2.Text = "radStatusStrip2";
            this.radStatusStrip2.ThemeName = "Material";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip2.SetSpring(this.radLabelElement1, true);
            this.radLabelElement1.Text = "v0.8.0.0";
            this.radLabelElement1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.UseCompatibleTextRendering = false;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.HeaderText = "Program Description";
            this.radGroupBox1.Location = new System.Drawing.Point(6, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(749, 212);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Program Description";
            this.radGroupBox1.ThemeName = "Material";
            // 
            // MainForm
            // 
            this.AcceptButton = this.PredictionPredictButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 643);
            this.Controls.Add(this.MainPageView);
            this.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Gold Stock Price Prediction System";
            this.ThemeName = "Material";
            this.Initialized += new System.EventHandler(this.MainForm_Initialized);
            ((System.ComponentModel.ISupportInitialize)(this.MainPageView)).EndInit();
            this.MainPageView.ResumeLayout(false);
            this.LivePredictionPage.ResumeLayout(false);
            this.LivePredictionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PredictionChartView)).EndInit();
            this.PredictionChartView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PredictionWaitingBar)).EndInit();
            this.PredictionGroupBox.ResumeLayout(false);
            this.PredictionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionScanTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionPredictButton)).EndInit();
            this.radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseToDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseFromDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabasePricesButton)).EndInit();
            this.AboutPage.ResumeLayout(false);
            this.AboutPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialTheme MatTheme;
        private RadPageView MainPageView;
        private RadPageViewPage LivePredictionPage;
        private RadPageViewPage AboutPage;
        private GroupBox groupBox2;
        private GroupBox PredictionGroupBox;
        private RadButton PredictionPredictButton;
        private RadDateTimePicker PredictionDateTimePicker;
        private RadTrackBar PredictionScanTrackBar;
        private RadLabel radLabel1;
        private RadChartView PredictionChartView;
        private RadGroupBox radGroupBox1;
        private RadStatusStrip radStatusStrip1;
        private RadLabelElement PredictionPriceLabel;
        private RadPageViewPage radPageViewPage1;
        private RadGridView DatabaseGridView;
        private GroupBox groupBox1;
        private RadDateTimePicker DatabaseToDateTimePicker;
        private RadDateTimePicker DatabaseFromDateTimePicker;
        private RadButton DatabasePricesButton;
        private RadStatusStrip radStatusStrip2;
        private RadLabelElement radLabelElement1;
        private RadWaitingBar PredictionWaitingBar;
        private DotsSpinnerWaitingBarIndicatorElement dotsSpinnerWaitingBarIndicatorElement1;
    }
}
