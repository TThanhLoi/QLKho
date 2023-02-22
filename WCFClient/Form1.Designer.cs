namespace WCFClient
{
    partial class Form1
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
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.gv_List = new System.Windows.Forms.DataGridView();
            this.btn_call = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(131, 70);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(39, 31);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Id";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(202, 70);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(777, 31);
            this.txt_Id.TabIndex = 1;
            // 
            // gv_List
            // 
            this.gv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_List.Location = new System.Drawing.Point(137, 152);
            this.gv_List.Name = "gv_List";
            this.gv_List.RowHeadersWidth = 82;
            this.gv_List.RowTemplate.Height = 33;
            this.gv_List.Size = new System.Drawing.Size(1066, 416);
            this.gv_List.TabIndex = 2;
            this.gv_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_List_CellContentClick);
            // 
            // btn_call
            // 
            this.btn_call.Location = new System.Drawing.Point(1029, 70);
            this.btn_call.Name = "btn_call";
            this.btn_call.Size = new System.Drawing.Size(174, 47);
            this.btn_call.TabIndex = 3;
            this.btn_call.Text = "Call Service";
            this.btn_call.UseVisualStyleBackColor = true;
            this.btn_call.Click += new System.EventHandler(this.btn_call_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 617);
            this.Controls.Add(this.btn_call);
            this.Controls.Add(this.gv_List);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gv_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.DataGridView gv_List;
        private System.Windows.Forms.Button btn_call;
    }
}

