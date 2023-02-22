namespace QLKho
{
    partial class FrmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            this.lbl_img = new DevExpress.XtraEditors.LabelControl();
            this.txt_img = new DevExpress.XtraEditors.TextEdit();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.gv_list = new System.Windows.Forms.DataGridView();
            this.lbl_name = new DevExpress.XtraEditors.LabelControl();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.lbl_id = new DevExpress.XtraEditors.LabelControl();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_img.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_img
            // 
            this.lbl_img.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_img.Appearance.Options.UseFont = true;
            this.lbl_img.Location = new System.Drawing.Point(20, 494);
            this.lbl_img.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(58, 39);
            this.lbl_img.TabIndex = 49;
            this.lbl_img.Text = "IMG";
            // 
            // txt_img
            // 
            this.txt_img.Location = new System.Drawing.Point(147, 489);
            this.txt_img.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_img.Name = "txt_img";
            this.txt_img.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_img.Properties.Appearance.Options.UseFont = true;
            this.txt_img.Size = new System.Drawing.Size(422, 54);
            this.txt_img.TabIndex = 47;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(1324, 678);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 56);
            this.btn_delete.TabIndex = 45;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(1024, 678);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(187, 56);
            this.btn_update.TabIndex = 44;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(804, 678);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 56);
            this.btn_add.TabIndex = 43;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.ForeColor = System.Drawing.Color.Red;
            this.lbl_Category.Location = new System.Drawing.Point(843, 117);
            this.lbl_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(529, 69);
            this.lbl_Category.TabIndex = 42;
            this.lbl_Category.Text = "Quản Lý Category";
            // 
            // gv_list
            // 
            this.gv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_list.Location = new System.Drawing.Point(854, 298);
            this.gv_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gv_list.Name = "gv_list";
            this.gv_list.RowHeadersWidth = 51;
            this.gv_list.RowTemplate.Height = 24;
            this.gv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_list.Size = new System.Drawing.Size(532, 366);
            this.gv_list.TabIndex = 41;
            this.gv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_list_CellContentClick);
            // 
            // lbl_name
            // 
            this.lbl_name.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Appearance.Options.UseFont = true;
            this.lbl_name.Location = new System.Drawing.Point(20, 400);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(123, 39);
            this.lbl_name.TabIndex = 39;
            this.lbl_name.Text = "Name(*)";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(147, 395);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Size = new System.Drawing.Size(422, 54);
            this.txt_name.TabIndex = 36;
            // 
            // lbl_id
            // 
            this.lbl_id.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Appearance.Options.UseFont = true;
            this.lbl_id.Location = new System.Drawing.Point(20, 298);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(75, 39);
            this.lbl_id.TabIndex = 40;
            this.lbl_id.Text = "ID(*)";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(147, 294);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Size = new System.Drawing.Size(422, 54);
            this.txt_id.TabIndex = 37;
            this.txt_id.EditValueChanged += new System.EventHandler(this.txt_id_EditValueChanged);
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            this.txt_id.SystemColorsChanged += new System.EventHandler(this.txt_id_SystemColorsChanged);
            this.txt_id.Validating += new System.ComponentModel.CancelEventHandler(this.txt_id_Validating);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 877);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1574, 42);
            this.statusStrip1.TabIndex = 51;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_message
            // 
            this.lbl_message.BackColor = System.Drawing.Color.Red;
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(237, 32);
            this.lbl_message.Text = "toolStripStatusLabel1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 919);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_img);
            this.Controls.Add(this.txt_img);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.gv_list);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_id);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_img.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbl_img;
        private DevExpress.XtraEditors.TextEdit txt_img;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DataGridView gv_list;
        private DevExpress.XtraEditors.LabelControl lbl_name;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.LabelControl lbl_id;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_message;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}