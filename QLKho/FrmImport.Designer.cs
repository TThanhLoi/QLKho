namespace QLKho
{
    partial class FrmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImport));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_username = new DevExpress.XtraEditors.LabelControl();
            this.lbl_state = new DevExpress.XtraEditors.LabelControl();
            this.txt_username = new DevExpress.XtraEditors.TextEdit();
            this.txt_status = new DevExpress.XtraEditors.TextEdit();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.gv_list = new System.Windows.Forms.DataGridView();
            this.lbl_total = new DevExpress.XtraEditors.LabelControl();
            this.lbl_productid = new DevExpress.XtraEditors.LabelControl();
            this.txt_total = new DevExpress.XtraEditors.TextEdit();
            this.lbl_id = new DevExpress.XtraEditors.LabelControl();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.lbl_import = new System.Windows.Forms.Label();
            this.lbl_supplier = new DevExpress.XtraEditors.LabelControl();
            this.lbl_impordate = new DevExpress.XtraEditors.LabelControl();
            this.dtp_import = new System.Windows.Forms.DateTimePicker();
            this.lbl_begininventory = new DevExpress.XtraEditors.LabelControl();
            this.txt_begininventory = new DevExpress.XtraEditors.TextEdit();
            this.lbl_endinventory = new DevExpress.XtraEditors.LabelControl();
            this.txt_endinventory = new DevExpress.XtraEditors.TextEdit();
            this.lbl_quantity = new DevExpress.XtraEditors.LabelControl();
            this.txt_quantity = new DevExpress.XtraEditors.TextEdit();
            this.lbl_note = new DevExpress.XtraEditors.LabelControl();
            this.txt_note = new DevExpress.XtraEditors.TextEdit();
            this.lbl_price = new DevExpress.XtraEditors.LabelControl();
            this.txt_price = new DevExpress.XtraEditors.TextEdit();
            this.cbx_supplier = new System.Windows.Forms.ComboBox();
            this.cbx_product = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_begininventory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_endinventory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_note.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1052);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2133, 42);
            this.statusStrip1.TabIndex = 49;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_message
            // 
            this.lbl_message.BackColor = System.Drawing.Color.Red;
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(237, 32);
            this.lbl_message.Text = "toolStripStatusLabel1";
            // 
            // lbl_username
            // 
            this.lbl_username.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Appearance.Options.UseFont = true;
            this.lbl_username.Location = new System.Drawing.Point(1272, 159);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(156, 39);
            this.lbl_username.TabIndex = 47;
            this.lbl_username.Text = "User Name";
            // 
            // lbl_state
            // 
            this.lbl_state.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.Appearance.Options.UseFont = true;
            this.lbl_state.Location = new System.Drawing.Point(20, 262);
            this.lbl_state.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(89, 39);
            this.lbl_state.TabIndex = 48;
            this.lbl_state.Text = "Status";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(1592, 152);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Properties.Appearance.Options.UseFont = true;
            this.txt_username.Size = new System.Drawing.Size(422, 54);
            this.txt_username.TabIndex = 45;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(147, 258);
            this.txt_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_status.Name = "txt_status";
            this.txt_status.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Properties.Appearance.Options.UseFont = true;
            this.txt_status.Size = new System.Drawing.Size(422, 54);
            this.txt_status.TabIndex = 46;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(1828, 566);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 56);
            this.btn_delete.TabIndex = 44;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(1525, 566);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(198, 56);
            this.btn_update.TabIndex = 43;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(1328, 566);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 56);
            this.btn_add.TabIndex = 42;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gv_list
            // 
            this.gv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_list.Location = new System.Drawing.Point(92, 653);
            this.gv_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gv_list.Name = "gv_list";
            this.gv_list.RowHeadersWidth = 51;
            this.gv_list.RowTemplate.Height = 24;
            this.gv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_list.Size = new System.Drawing.Size(1884, 366);
            this.gv_list.TabIndex = 41;
            this.gv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_list_CellContentClick);
            // 
            // lbl_total
            // 
            this.lbl_total.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Appearance.Options.UseFont = true;
            this.lbl_total.Location = new System.Drawing.Point(646, 438);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(71, 39);
            this.lbl_total.TabIndex = 38;
            this.lbl_total.Text = "Total";
            this.lbl_total.Click += new System.EventHandler(this.lbl_address_Click);
            // 
            // lbl_productid
            // 
            this.lbl_productid.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productid.Appearance.Options.UseFont = true;
            this.lbl_productid.Location = new System.Drawing.Point(646, 156);
            this.lbl_productid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_productid.Name = "lbl_productid";
            this.lbl_productid.Size = new System.Drawing.Size(109, 39);
            this.lbl_productid.TabIndex = 39;
            this.lbl_productid.Text = "Product";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(774, 428);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_total.Name = "txt_total";
            this.txt_total.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Properties.Appearance.Options.UseFont = true;
            this.txt_total.Size = new System.Drawing.Size(422, 54);
            this.txt_total.TabIndex = 35;
            this.txt_total.EditValueChanged += new System.EventHandler(this.txt_address_EditValueChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Appearance.Options.UseFont = true;
            this.lbl_id.Location = new System.Drawing.Point(20, 156);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(34, 39);
            this.lbl_id.TabIndex = 40;
            this.lbl_id.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(147, 152);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(422, 54);
            this.txt_id.TabIndex = 37;
            // 
            // lbl_import
            // 
            this.lbl_import.AutoSize = true;
            this.lbl_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_import.ForeColor = System.Drawing.Color.Red;
            this.lbl_import.Location = new System.Drawing.Point(706, 30);
            this.lbl_import.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_import.Name = "lbl_import";
            this.lbl_import.Size = new System.Drawing.Size(455, 69);
            this.lbl_import.TabIndex = 50;
            this.lbl_import.Text = "Quản Lý Import";
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplier.Appearance.Options.UseFont = true;
            this.lbl_supplier.Location = new System.Drawing.Point(646, 262);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(115, 39);
            this.lbl_supplier.TabIndex = 52;
            this.lbl_supplier.Text = "Supplier";
            // 
            // lbl_impordate
            // 
            this.lbl_impordate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_impordate.Appearance.Options.UseFont = true;
            this.lbl_impordate.Location = new System.Drawing.Point(1269, 440);
            this.lbl_impordate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_impordate.Name = "lbl_impordate";
            this.lbl_impordate.Size = new System.Drawing.Size(174, 39);
            this.lbl_impordate.TabIndex = 54;
            this.lbl_impordate.Text = "Import Date";
            // 
            // dtp_import
            // 
            this.dtp_import.Location = new System.Drawing.Point(1592, 436);
            this.dtp_import.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_import.Name = "dtp_import";
            this.dtp_import.Size = new System.Drawing.Size(426, 31);
            this.dtp_import.TabIndex = 55;
            // 
            // lbl_begininventory
            // 
            this.lbl_begininventory.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_begininventory.Appearance.Options.UseFont = true;
            this.lbl_begininventory.Location = new System.Drawing.Point(1272, 256);
            this.lbl_begininventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_begininventory.Name = "lbl_begininventory";
            this.lbl_begininventory.Size = new System.Drawing.Size(287, 39);
            this.lbl_begininventory.TabIndex = 57;
            this.lbl_begininventory.Text = "Beginning Inventory";
            // 
            // txt_begininventory
            // 
            this.txt_begininventory.Location = new System.Drawing.Point(1592, 253);
            this.txt_begininventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_begininventory.Name = "txt_begininventory";
            this.txt_begininventory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_begininventory.Properties.Appearance.Options.UseFont = true;
            this.txt_begininventory.Size = new System.Drawing.Size(422, 54);
            this.txt_begininventory.TabIndex = 56;
            // 
            // lbl_endinventory
            // 
            this.lbl_endinventory.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endinventory.Appearance.Options.UseFont = true;
            this.lbl_endinventory.Location = new System.Drawing.Point(1272, 337);
            this.lbl_endinventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_endinventory.Name = "lbl_endinventory";
            this.lbl_endinventory.Size = new System.Drawing.Size(244, 39);
            this.lbl_endinventory.TabIndex = 59;
            this.lbl_endinventory.Text = "Ending Inventory";
            // 
            // txt_endinventory
            // 
            this.txt_endinventory.Location = new System.Drawing.Point(1592, 334);
            this.txt_endinventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_endinventory.Name = "txt_endinventory";
            this.txt_endinventory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endinventory.Properties.Appearance.Options.UseFont = true;
            this.txt_endinventory.Size = new System.Drawing.Size(422, 54);
            this.txt_endinventory.TabIndex = 58;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Appearance.Options.UseFont = true;
            this.lbl_quantity.Location = new System.Drawing.Point(646, 344);
            this.lbl_quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(121, 39);
            this.lbl_quantity.TabIndex = 61;
            this.lbl_quantity.Text = "Quantity";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(774, 339);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Properties.Appearance.Options.UseFont = true;
            this.txt_quantity.Size = new System.Drawing.Size(422, 54);
            this.txt_quantity.TabIndex = 60;
            // 
            // lbl_note
            // 
            this.lbl_note.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_note.Appearance.Options.UseFont = true;
            this.lbl_note.Location = new System.Drawing.Point(20, 344);
            this.lbl_note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(66, 39);
            this.lbl_note.TabIndex = 63;
            this.lbl_note.Text = "Note";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(147, 339);
            this.txt_note.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_note.Name = "txt_note";
            this.txt_note.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Properties.Appearance.Options.UseFont = true;
            this.txt_note.Size = new System.Drawing.Size(422, 54);
            this.txt_note.TabIndex = 62;
            // 
            // lbl_price
            // 
            this.lbl_price.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Appearance.Options.UseFont = true;
            this.lbl_price.Location = new System.Drawing.Point(20, 438);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(69, 39);
            this.lbl_price.TabIndex = 65;
            this.lbl_price.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(147, 433);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_price.Name = "txt_price";
            this.txt_price.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Properties.Appearance.Options.UseFont = true;
            this.txt_price.Size = new System.Drawing.Size(422, 54);
            this.txt_price.TabIndex = 64;
            // 
            // cbx_supplier
            // 
            this.cbx_supplier.FormattingEnabled = true;
            this.cbx_supplier.Location = new System.Drawing.Point(774, 258);
            this.cbx_supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_supplier.Name = "cbx_supplier";
            this.cbx_supplier.Size = new System.Drawing.Size(420, 33);
            this.cbx_supplier.TabIndex = 66;
            // 
            // cbx_product
            // 
            this.cbx_product.FormattingEnabled = true;
            this.cbx_product.Location = new System.Drawing.Point(774, 156);
            this.cbx_product.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_product.Name = "cbx_product";
            this.cbx_product.Size = new System.Drawing.Size(420, 33);
            this.cbx_product.TabIndex = 67;
            // 
            // FrmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1094);
            this.Controls.Add(this.cbx_product);
            this.Controls.Add(this.cbx_supplier);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_endinventory);
            this.Controls.Add(this.txt_endinventory);
            this.Controls.Add(this.lbl_begininventory);
            this.Controls.Add(this.txt_begininventory);
            this.Controls.Add(this.dtp_import);
            this.Controls.Add(this.lbl_impordate);
            this.Controls.Add(this.lbl_supplier);
            this.Controls.Add(this.lbl_import);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.gv_list);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_productid);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmImport";
            this.Text = "FrmImport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImport_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_begininventory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_endinventory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_note.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_message;
        private DevExpress.XtraEditors.LabelControl lbl_username;
        private DevExpress.XtraEditors.LabelControl lbl_state;
        private DevExpress.XtraEditors.TextEdit txt_username;
        private DevExpress.XtraEditors.TextEdit txt_status;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView gv_list;
        private DevExpress.XtraEditors.LabelControl lbl_total;
        private DevExpress.XtraEditors.LabelControl lbl_productid;
        private DevExpress.XtraEditors.TextEdit txt_total;
        private DevExpress.XtraEditors.LabelControl lbl_id;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private System.Windows.Forms.Label lbl_import;
        private DevExpress.XtraEditors.LabelControl lbl_supplier;
        private DevExpress.XtraEditors.LabelControl lbl_impordate;
        private System.Windows.Forms.DateTimePicker dtp_import;
        private DevExpress.XtraEditors.LabelControl lbl_begininventory;
        private DevExpress.XtraEditors.TextEdit txt_begininventory;
        private DevExpress.XtraEditors.LabelControl lbl_endinventory;
        private DevExpress.XtraEditors.TextEdit txt_endinventory;
        private DevExpress.XtraEditors.LabelControl lbl_quantity;
        private DevExpress.XtraEditors.TextEdit txt_quantity;
        private DevExpress.XtraEditors.LabelControl lbl_note;
        private DevExpress.XtraEditors.TextEdit txt_note;
        private DevExpress.XtraEditors.LabelControl lbl_price;
        private DevExpress.XtraEditors.TextEdit txt_price;
        private System.Windows.Forms.ComboBox cbx_supplier;
        private System.Windows.Forms.ComboBox cbx_product;
    }
}