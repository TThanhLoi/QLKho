namespace QLKho
{
    partial class FrmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupplier));
            this.lbl_address = new DevExpress.XtraEditors.LabelControl();
            this.lbl_name = new DevExpress.XtraEditors.LabelControl();
            this.txt_address = new DevExpress.XtraEditors.TextEdit();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.lbl_id = new DevExpress.XtraEditors.LabelControl();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.gv_list = new System.Windows.Forms.DataGridView();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_vat = new DevExpress.XtraEditors.LabelControl();
            this.lbl_url = new DevExpress.XtraEditors.LabelControl();
            this.txt_vat = new DevExpress.XtraEditors.TextEdit();
            this.txt_url = new DevExpress.XtraEditors.TextEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_message = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_url.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_address
            // 
            this.lbl_address.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Appearance.Options.UseFont = true;
            this.lbl_address.Location = new System.Drawing.Point(20, 503);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(112, 39);
            this.lbl_address.TabIndex = 21;
            this.lbl_address.Text = "Address";
            // 
            // lbl_name
            // 
            this.lbl_name.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Appearance.Options.UseFont = true;
            this.lbl_name.Location = new System.Drawing.Point(20, 408);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(82, 39);
            this.lbl_name.TabIndex = 22;
            this.lbl_name.Text = "Name";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(147, 498);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_address.Name = "txt_address";
            this.txt_address.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Properties.Appearance.Options.UseFont = true;
            this.txt_address.Size = new System.Drawing.Size(422, 54);
            this.txt_address.TabIndex = 18;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(147, 403);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Size = new System.Drawing.Size(422, 54);
            this.txt_name.TabIndex = 19;
            // 
            // lbl_id
            // 
            this.lbl_id.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Appearance.Options.UseFont = true;
            this.lbl_id.Location = new System.Drawing.Point(20, 306);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(34, 39);
            this.lbl_id.TabIndex = 23;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(147, 302);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(422, 54);
            this.txt_id.TabIndex = 20;
            // 
            // gv_list
            // 
            this.gv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_list.Location = new System.Drawing.Point(657, 306);
            this.gv_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gv_list.Name = "gv_list";
            this.gv_list.RowHeadersWidth = 51;
            this.gv_list.RowTemplate.Height = 24;
            this.gv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_list.Size = new System.Drawing.Size(834, 366);
            this.gv_list.TabIndex = 24;
            this.gv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_list_CellContentClick);
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier.ForeColor = System.Drawing.Color.Red;
            this.lbl_Supplier.Location = new System.Drawing.Point(442, 104);
            this.lbl_Supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(505, 69);
            this.lbl_Supplier.TabIndex = 25;
            this.lbl_Supplier.Text = "Quản Lý Supplier";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(1180, 686);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 56);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(891, 686);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(184, 56);
            this.btn_update.TabIndex = 27;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(680, 686);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 56);
            this.btn_add.TabIndex = 26;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_vat
            // 
            this.lbl_vat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vat.Appearance.Options.UseFont = true;
            this.lbl_vat.Location = new System.Drawing.Point(20, 691);
            this.lbl_vat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_vat.Name = "lbl_vat";
            this.lbl_vat.Size = new System.Drawing.Size(47, 39);
            this.lbl_vat.TabIndex = 31;
            this.lbl_vat.Text = "Vat";
            // 
            // lbl_url
            // 
            this.lbl_url.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_url.Appearance.Options.UseFont = true;
            this.lbl_url.Location = new System.Drawing.Point(20, 595);
            this.lbl_url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(40, 39);
            this.lbl_url.TabIndex = 32;
            this.lbl_url.Text = "Url";
            // 
            // txt_vat
            // 
            this.txt_vat.Location = new System.Drawing.Point(147, 686);
            this.txt_vat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_vat.Name = "txt_vat";
            this.txt_vat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vat.Properties.Appearance.Options.UseFont = true;
            this.txt_vat.Size = new System.Drawing.Size(422, 54);
            this.txt_vat.TabIndex = 29;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(147, 591);
            this.txt_url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_url.Name = "txt_url";
            this.txt_url.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.Properties.Appearance.Options.UseFont = true;
            this.txt_url.Size = new System.Drawing.Size(422, 54);
            this.txt_url.TabIndex = 30;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 755);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1509, 42);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_message
            // 
            this.lbl_message.BackColor = System.Drawing.Color.Red;
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(237, 32);
            this.lbl_message.Text = "toolStripStatusLabel1";
            // 
            // FrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 797);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_vat);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.txt_vat);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_Supplier);
            this.Controls.Add(this.gv_list);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSupplier";
            this.Text = "FrmSupplier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_url.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_address;
        private DevExpress.XtraEditors.LabelControl lbl_name;
        private DevExpress.XtraEditors.TextEdit txt_address;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.LabelControl lbl_id;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private System.Windows.Forms.DataGridView gv_list;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private DevExpress.XtraEditors.LabelControl lbl_vat;
        private DevExpress.XtraEditors.LabelControl lbl_url;
        private DevExpress.XtraEditors.TextEdit txt_vat;
        private DevExpress.XtraEditors.TextEdit txt_url;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_message;
    }
}