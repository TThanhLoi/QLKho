using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QLKHO;
using ReportsForm;
namespace QLKho
{
    public partial class FrmMain : Form
    {
        bool isthoat = true;
        private UserBUS bus = new UserBUS();
        public FrmMain(string username)
        {
            InitializeComponent();
            lbl_hellouser.Text = username;
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void viewAllAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isthoat = false;
            this.Close();
            FrmLogin f = new FrmLogin();
            f.Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isthoat)
                Application.Exit();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //child form
            Frm_product child_1 = new Frm_product();
            child_1.MdiParent = this;
            child_1.Show();
        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAccount child_1 = new FrmAccount();
            child_1.MdiParent = this;
            child_1.Show();
        }

        private void viewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategory child_1 = new FrmCategory();
            child_1.MdiParent = this;
            child_1.Show();
        }

        private void viewImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImport child_1 = new FrmImport();
            child_1.MdiParent = this;
            child_1.Show();
        }

        private void viewExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExport child_1 = new FrmExport();
            child_1.MdiParent = this;
            child_1.Show();
        }

        private void viewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplier child_1 = new FrmSupplier();
            child_1.MdiParent = this;
            child_1.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Frm_ExportRpt child_1 = new Frm_ExportRpt();
            child_1.MdiParent = this;
            child_1.Show();
        }
    }
}
