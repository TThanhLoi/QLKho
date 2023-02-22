namespace ReportsForm
{
    partial class Frm_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ImportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClothesDataSet1 = new ReportsForm.ClothesDataSet1();
            this.View_ImportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClothesDataSet = new ReportsForm.ClothesDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_ImportTableAdapter = new ReportsForm.ClothesDataSet1TableAdapters.View_ImportTableAdapter();
            this.btn_Load = new System.Windows.Forms.Button();
            this.ImportTableAdapter = new ReportsForm.ClothesDataSet1TableAdapters.ImportTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_ImportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportBindingSource
            // 
            this.ImportBindingSource.DataMember = "Import";
            this.ImportBindingSource.DataSource = this.ClothesDataSet1;
            // 
            // ClothesDataSet1
            // 
            this.ClothesDataSet1.DataSetName = "ClothesDataSet1";
            this.ClothesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_ImportBindingSource
            // 
            this.View_ImportBindingSource.DataMember = "View_Import";
            this.View_ImportBindingSource.DataSource = this.ClothesDataSet;
            // 
            // ClothesDataSet
            // 
            this.ClothesDataSet.DataSetName = "ClothesDataSet";
            this.ClothesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ImportDataSet";
            reportDataSource1.Value = this.ImportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsForm.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(77, 120);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1860, 402);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // View_ImportTableAdapter
            // 
            this.View_ImportTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(77, 50);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(180, 48);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load Report";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // ImportTableAdapter
            // 
            this.ImportTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(77, 540);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Import_Quantity";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(725, 375);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(510, 50);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(180, 48);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Frm_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2038, 940);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Report";
            this.Text = "Frm_Report";
            this.Load += new System.EventHandler(this.Frm_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_ImportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_ImportBindingSource;
        private ClothesDataSet1 ClothesDataSet;
        private ClothesDataSet1TableAdapters.View_ImportTableAdapter View_ImportTableAdapter;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.BindingSource ImportBindingSource;
        private ClothesDataSet1 ClothesDataSet1;
        private ClothesDataSet1TableAdapters.ImportTableAdapter ImportTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_next;
    }
}