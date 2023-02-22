using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsForm
{
    public partial class Frm_ExportRpt : Form
    {
        public Frm_ExportRpt()
        {
            InitializeComponent();
        }

        private void Frm_ExportRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClothesDataSet.vw_Export' table. You can move, or remove it, as needed.
            this.vw_ExportTableAdapter.Fill(this.ClothesDataSet.vw_Export);

            this.reportViewer1.RefreshReport();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LocalReport report = reportViewer1.LocalReport;
            report.DataSources.Clear();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;User Id=sa; Password=1; database=Clothes";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from vw_Import", con);
            try
            {
                con.Open();
                adapter.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {

            }

            ReportDataSource dsExports = new ReportDataSource();
            dsExports.Name = "DSExport";

            dsExports.Value = ds.Tables[0];

            report.DataSources.Add(dsExports);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_CLChart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_CLChart ls = new Frm_CLChart();
            ls.Show();

        }

        private void btn_PieChart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_PieExport pe = new Frm_PieExport();
            pe.Show();
        }
    }
}
