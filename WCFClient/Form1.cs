using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFClient.VanlaMon;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gv_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_call_Click(object sender, EventArgs e)
        {
            InsuaranceServiceClient client = new InsuaranceServiceClient();
            gv_List.DataSource = client.GetAllImportProcessesById(txt_Id.Text);
        }
    }
}
