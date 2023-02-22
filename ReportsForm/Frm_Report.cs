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
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
        }

        private void Frm_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClothesDataSet1.Import' table. You can move, or remove it, as needed.
            this.ImportTableAdapter.Fill(this.ClothesDataSet1.Import);
            // TODO: This line of code loads data into the 'ClothesDataSet.View_Import' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
            fillChart();
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

            ReportDataSource dsImports = new ReportDataSource();
            dsImports.Name = "DSImport";

            dsImports.Value = ds.Tables[0];

            report.DataSources.Add(dsImports);
            this.reportViewer1.RefreshReport();

            

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void fillChart()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;User Id=sa; Password=1; database=Clothes";
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from vw_Import", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Import_Quantity"].XValueMember = "UserName";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Import_Quantity"].YValueMembers = "Import_Quantity";
            chart1.Titles.Add("Quantity Chart");
            con.Close();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            LineChart ls = new LineChart();
            ls.Show();
            
        }
    }
}
