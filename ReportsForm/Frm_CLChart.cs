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
    public partial class Frm_CLChart : Form
    {
        public Frm_CLChart()
        {
            InitializeComponent();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_CLChart_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        private void fillChart()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;User Id=sa; Password=1; database=Clothes";
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from vw_Export", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Export_Date"].XValueMember = "Name";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Export_Date"].YValueMembers = "Export_Date";
            chart1.Titles.Add("Quantity Chart");
            con.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_ExportRpt frp = new Frm_ExportRpt();
            frp.Show();
        }
    }
}
