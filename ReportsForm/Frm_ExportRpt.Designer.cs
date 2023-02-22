namespace ReportsForm
{
    partial class Frm_ExportRpt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btn_Load = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClothesDataSet = new ReportsForm.ClothesDataSet();
            this.vw_ExportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_ExportTableAdapter = new ReportsForm.ClothesDataSetTableAdapters.vw_ExportTableAdapter();
            this.btn_CLChart = new System.Windows.Forms.Button();
            this.btn_PieChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ExportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.Location = new System.Drawing.Point(153, 52);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(158, 59);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "ExportDataSet";
            reportDataSource2.Value = this.vw_ExportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsForm.Reports.ReportExport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(153, 142);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1564, 565);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ClothesDataSet
            // 
            this.ClothesDataSet.DataSetName = "ClothesDataSet";
            this.ClothesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_ExportBindingSource
            // 
            this.vw_ExportBindingSource.DataMember = "vw_Export";
            this.vw_ExportBindingSource.DataSource = this.ClothesDataSet;
            // 
            // vw_ExportTableAdapter
            // 
            this.vw_ExportTableAdapter.ClearBeforeFill = true;
            // 
            // btn_CLChart
            // 
            this.btn_CLChart.Location = new System.Drawing.Point(467, 52);
            this.btn_CLChart.Name = "btn_CLChart";
            this.btn_CLChart.Size = new System.Drawing.Size(171, 59);
            this.btn_CLChart.TabIndex = 2;
            this.btn_CLChart.Text = "Columm Chart";
            this.btn_CLChart.UseVisualStyleBackColor = true;
            this.btn_CLChart.Click += new System.EventHandler(this.btn_CLChart_Click);
            // 
            // btn_PieChart
            // 
            this.btn_PieChart.Location = new System.Drawing.Point(786, 55);
            this.btn_PieChart.Name = "btn_PieChart";
            this.btn_PieChart.Size = new System.Drawing.Size(171, 59);
            this.btn_PieChart.TabIndex = 2;
            this.btn_PieChart.Text = "Pie Chart";
            this.btn_PieChart.UseVisualStyleBackColor = true;
            this.btn_PieChart.Click += new System.EventHandler(this.btn_PieChart_Click);
            // 
            // Frm_ExportRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 798);
            this.Controls.Add(this.btn_PieChart);
            this.Controls.Add(this.btn_CLChart);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_Load);
            this.Name = "Frm_ExportRpt";
            this.Text = "Frm_ExportRpt";
            this.Load += new System.EventHandler(this.Frm_ExportRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClothesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ExportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_ExportBindingSource;
        private ClothesDataSet ClothesDataSet;
        private ClothesDataSetTableAdapters.vw_ExportTableAdapter vw_ExportTableAdapter;
        private System.Windows.Forms.Button btn_CLChart;
        private System.Windows.Forms.Button btn_PieChart;
    }
}