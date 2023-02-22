namespace QLKho
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_product = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_account = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_hellouser = new System.Windows.Forms.Label();
            this.lbl_xinchao = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ctx_mnu_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_product,
            this.categoryManageToolStripMenuItem,
            this.importManagerToolStripMenuItem,
            this.exportMangerToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.mnu_account,
            this.supplierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1996, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_product
            // 
            this.mnu_product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllToolStripMenuItem,
            this.addToolStripMenuItem});
            this.mnu_product.Name = "mnu_product";
            this.mnu_product.Size = new System.Drawing.Size(116, 36);
            this.mnu_product.Text = "Product";
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(225, 44);
            this.viewAllToolStripMenuItem.Text = "ViewAll";
            this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.viewAllToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(225, 44);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // categoryManageToolStripMenuItem
            // 
            this.categoryManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCategoryToolStripMenuItem});
            this.categoryManageToolStripMenuItem.Name = "categoryManageToolStripMenuItem";
            this.categoryManageToolStripMenuItem.Size = new System.Drawing.Size(232, 36);
            this.categoryManageToolStripMenuItem.Text = "Category Manager";
            // 
            // viewCategoryToolStripMenuItem
            // 
            this.viewCategoryToolStripMenuItem.Checked = true;
            this.viewCategoryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewCategoryToolStripMenuItem.Name = "viewCategoryToolStripMenuItem";
            this.viewCategoryToolStripMenuItem.Size = new System.Drawing.Size(294, 44);
            this.viewCategoryToolStripMenuItem.Text = "ViewCategory";
            this.viewCategoryToolStripMenuItem.Click += new System.EventHandler(this.viewCategoryToolStripMenuItem_Click);
            // 
            // importManagerToolStripMenuItem
            // 
            this.importManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewImportToolStripMenuItem});
            this.importManagerToolStripMenuItem.Name = "importManagerToolStripMenuItem";
            this.importManagerToolStripMenuItem.Size = new System.Drawing.Size(207, 36);
            this.importManagerToolStripMenuItem.Text = "Import Manager";
            // 
            // viewImportToolStripMenuItem
            // 
            this.viewImportToolStripMenuItem.Name = "viewImportToolStripMenuItem";
            this.viewImportToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.viewImportToolStripMenuItem.Text = "View Import";
            this.viewImportToolStripMenuItem.Click += new System.EventHandler(this.viewImportToolStripMenuItem_Click);
            // 
            // exportMangerToolStripMenuItem
            // 
            this.exportMangerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewExportToolStripMenuItem});
            this.exportMangerToolStripMenuItem.Name = "exportMangerToolStripMenuItem";
            this.exportMangerToolStripMenuItem.Size = new System.Drawing.Size(203, 36);
            this.exportMangerToolStripMenuItem.Text = "Export Manager";
            // 
            // viewExportToolStripMenuItem
            // 
            this.viewExportToolStripMenuItem.Name = "viewExportToolStripMenuItem";
            this.viewExportToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.viewExportToolStripMenuItem.Text = "View Export";
            this.viewExportToolStripMenuItem.Click += new System.EventHandler(this.viewExportToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllAccountToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // viewAllAccountToolStripMenuItem
            // 
            this.viewAllAccountToolStripMenuItem.Name = "viewAllAccountToolStripMenuItem";
            this.viewAllAccountToolStripMenuItem.Size = new System.Drawing.Size(222, 44);
            this.viewAllAccountToolStripMenuItem.Text = "Logout";
            this.viewAllAccountToolStripMenuItem.Click += new System.EventHandler(this.viewAllAccountToolStripMenuItem_Click);
            // 
            // mnu_account
            // 
            this.mnu_account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllToolStripMenuItem1});
            this.mnu_account.Name = "mnu_account";
            this.mnu_account.Size = new System.Drawing.Size(121, 36);
            this.mnu_account.Text = "Account";
            // 
            // viewAllToolStripMenuItem1
            // 
            this.viewAllToolStripMenuItem1.Name = "viewAllToolStripMenuItem1";
            this.viewAllToolStripMenuItem1.Size = new System.Drawing.Size(232, 44);
            this.viewAllToolStripMenuItem1.Text = "View All";
            this.viewAllToolStripMenuItem1.Click += new System.EventHandler(this.viewAllToolStripMenuItem1_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSupplierToolStripMenuItem});
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.supplierToolStripMenuItem.Text = "Supplier";
            // 
            // viewSupplierToolStripMenuItem
            // 
            this.viewSupplierToolStripMenuItem.Name = "viewSupplierToolStripMenuItem";
            this.viewSupplierToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.viewSupplierToolStripMenuItem.Text = "View Supplier";
            this.viewSupplierToolStripMenuItem.Click += new System.EventHandler(this.viewSupplierToolStripMenuItem_Click);
            // 
            // lbl_hellouser
            // 
            this.lbl_hellouser.AutoSize = true;
            this.lbl_hellouser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hellouser.Location = new System.Drawing.Point(1732, 14);
            this.lbl_hellouser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hellouser.Name = "lbl_hellouser";
            this.lbl_hellouser.Size = new System.Drawing.Size(42, 33);
            this.lbl_hellouser.TabIndex = 9;
            this.lbl_hellouser.Tag = "";
            this.lbl_hellouser.Text = "...";
            // 
            // lbl_xinchao
            // 
            this.lbl_xinchao.AutoSize = true;
            this.lbl_xinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xinchao.Location = new System.Drawing.Point(1586, 14);
            this.lbl_xinchao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_xinchao.Name = "lbl_xinchao";
            this.lbl_xinchao.Size = new System.Drawing.Size(142, 33);
            this.lbl_xinchao.TabIndex = 8;
            this.lbl_xinchao.Text = "Xin Chào";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 42);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1996, 38);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 32);
            this.toolStripLabel1.Text = "Report";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // ctx_mnu_main
            // 
            this.ctx_mnu_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctx_mnu_main.Name = "contextMenuStrip1";
            this.ctx_mnu_main.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 770);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1996, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1996, 792);
            this.ContextMenuStrip = this.ctx_mnu_main;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbl_hellouser);
            this.Controls.Add(this.lbl_xinchao);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_product;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllAccountToolStripMenuItem;
        private System.Windows.Forms.Label lbl_hellouser;
        private System.Windows.Forms.Label lbl_xinchao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ContextMenuStrip ctx_mnu_main;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_account;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSupplierToolStripMenuItem;
    }
}