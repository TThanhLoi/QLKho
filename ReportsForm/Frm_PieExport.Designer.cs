namespace ReportsForm
{
    partial class Frm_PieExport
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
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.lbl_PercentPie = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(340, 231);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(1024, 547);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            this.pieChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.pieChart1_ChildChanged);
            // 
            // lbl_PercentPie
            // 
            this.lbl_PercentPie.AutoSize = true;
            this.lbl_PercentPie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PercentPie.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_PercentPie.Location = new System.Drawing.Point(690, 103);
            this.lbl_PercentPie.Name = "lbl_PercentPie";
            this.lbl_PercentPie.Size = new System.Drawing.Size(325, 31);
            this.lbl_PercentPie.TabIndex = 1;
            this.lbl_PercentPie.Text = "Percent Quantity Export";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1309, 762);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(171, 59);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Exit";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Frm_PieExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 866);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_PercentPie);
            this.Controls.Add(this.pieChart1);
            this.Name = "Frm_PieExport";
            this.Text = "Frm_PieExport";
            this.Load += new System.EventHandler(this.Frm_PieExport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label lbl_PercentPie;
        private System.Windows.Forms.Button btn_back;
    }
}