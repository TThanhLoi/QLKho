namespace QLKho
{
    partial class FrmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccount));
            this.gv_list = new System.Windows.Forms.DataGridView();
            this.lbl_qluser = new System.Windows.Forms.Label();
            this.lbl_username = new DevExpress.XtraEditors.LabelControl();
            this.txt_username = new DevExpress.XtraEditors.TextEdit();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.lbl_password = new DevExpress.XtraEditors.LabelControl();
            this.txt_role = new DevExpress.XtraEditors.TextEdit();
            this.lbl_role = new DevExpress.XtraEditors.LabelControl();
            this.btn_add = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_role.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_list
            // 
            this.gv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_list.Location = new System.Drawing.Point(716, 294);
            this.gv_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gv_list.Name = "gv_list";
            this.gv_list.RowHeadersWidth = 51;
            this.gv_list.RowTemplate.Height = 24;
            this.gv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_list.Size = new System.Drawing.Size(699, 366);
            this.gv_list.TabIndex = 0;
            this.gv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_qluser
            // 
            this.lbl_qluser.AutoSize = true;
            this.lbl_qluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qluser.ForeColor = System.Drawing.Color.Red;
            this.lbl_qluser.Location = new System.Drawing.Point(452, 92);
            this.lbl_qluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qluser.Name = "lbl_qluser";
            this.lbl_qluser.Size = new System.Drawing.Size(582, 69);
            this.lbl_qluser.TabIndex = 1;
            this.lbl_qluser.Text = "Quản Lý ACCOUNT";
            // 
            // lbl_username
            // 
            this.lbl_username.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Appearance.Options.UseFont = true;
            this.lbl_username.Location = new System.Drawing.Point(42, 352);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(156, 39);
            this.lbl_username.TabIndex = 17;
            this.lbl_username.Text = "User Name";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(218, 347);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Properties.Appearance.Options.UseFont = true;
            this.txt_username.Size = new System.Drawing.Size(422, 54);
            this.txt_username.TabIndex = 16;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(218, 438);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Properties.Appearance.Options.UseFont = true;
            this.txt_password.Properties.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(422, 54);
            this.txt_password.TabIndex = 16;
            // 
            // lbl_password
            // 
            this.lbl_password.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Appearance.Options.UseFont = true;
            this.lbl_password.Location = new System.Drawing.Point(42, 443);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(139, 39);
            this.lbl_password.TabIndex = 17;
            this.lbl_password.Text = "PassWord";
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(218, 532);
            this.txt_role.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_role.Name = "txt_role";
            this.txt_role.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_role.Properties.Appearance.Options.UseFont = true;
            this.txt_role.Size = new System.Drawing.Size(422, 54);
            this.txt_role.TabIndex = 16;
            // 
            // lbl_role
            // 
            this.lbl_role.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Appearance.Options.UseFont = true;
            this.lbl_role.Location = new System.Drawing.Point(42, 536);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(61, 39);
            this.lbl_role.TabIndex = 17;
            this.lbl_role.Text = "Role";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(34, 664);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 56);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 804);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1559, 42);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_message
            // 
            this.lbl_message.BackColor = System.Drawing.Color.Red;
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(237, 32);
            this.lbl_message.Text = "toolStripStatusLabel1";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Blue;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(218, 664);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(180, 56);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Crimson;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(453, 664);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 56);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1559, 846);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_qluser);
            this.Controls.Add(this.gv_list);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAccount";
            this.Text = "FrmAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_role.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_list;
        private System.Windows.Forms.Label lbl_qluser;
        private DevExpress.XtraEditors.LabelControl lbl_username;
        private DevExpress.XtraEditors.TextEdit txt_username;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.LabelControl lbl_password;
        private DevExpress.XtraEditors.TextEdit txt_role;
        private DevExpress.XtraEditors.LabelControl lbl_role;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_message;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}