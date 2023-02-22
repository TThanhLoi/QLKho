namespace WCFClient
{
    partial class Form2
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_CallEx = new System.Windows.Forms.TextBox();
            this.btn_CallEx = new System.Windows.Forms.Button();
            this.gv_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(141, 76);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(39, 31);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Id";
            // 
            // txt_CallEx
            // 
            this.txt_CallEx.Location = new System.Drawing.Point(207, 79);
            this.txt_CallEx.Name = "txt_CallEx";
            this.txt_CallEx.Size = new System.Drawing.Size(583, 31);
            this.txt_CallEx.TabIndex = 1;
            // 
            // btn_CallEx
            // 
            this.btn_CallEx.Location = new System.Drawing.Point(812, 79);
            this.btn_CallEx.Name = "btn_CallEx";
            this.btn_CallEx.Size = new System.Drawing.Size(150, 31);
            this.btn_CallEx.TabIndex = 2;
            this.btn_CallEx.Text = "Call Service";
            this.btn_CallEx.UseVisualStyleBackColor = true;
            this.btn_CallEx.Click += new System.EventHandler(this.btn_CallEx_Click);
            // 
            // gv_List
            // 
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Location = new System.Drawing.Point(198, 185);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 82;
            this.gv_List.RowTemplate.Height = 33;
            this.gv_List.Size = new System.Drawing.Size(1024, 506);
            this.gv_List.TabIndex = 3;
            this.gv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 739);
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.btn_CallEx);
            this.Controls.Add(this.txt_CallEx);
            this.Controls.Add(this.lbl_Id);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_CallEx;
        private System.Windows.Forms.Button btn_CallEx;
        private System.Windows.Forms.DataGridView gv_List;
    }
}