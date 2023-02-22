using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFWebClient.MonClient;

namespace WCFWebClient
{
    public partial class ViewImport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Call_Click(object sender, EventArgs e)
        {
            MonClient.InsuaranceServiceClient client = new MonClient.InsuaranceServiceClient();
            gv_LstImport.DataSource = client.GetAllImportProcessesById(txt_Id.Text);
            gv_LstImport.DataBind();
        }
    }
}