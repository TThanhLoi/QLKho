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

namespace QLKho
{
    public partial class FrmLogin : Form
    {
        private BindingSource bs = new BindingSource();
        private UserBUS bus = new UserBUS();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username == null || username.Equals(""))
            {
                MessageBox.Show("chua nhap user name");
            }
            if (password == null || username.Equals(""))
            {
                MessageBox.Show("chua nhap password");
            }

            //3. call BUS --> insert into db
            bool result = bus.checkUserName(username, password);
            if (result)
            {
                lbl_message.Text = "successfully!!";
                FrmMain frmmain = new FrmMain(username);
                frmmain.Show();
                this.Hide();
            }
            else
                lbl_message.Text = "Fail!!";

            //4. load refresh to grid   
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister frr = new FrmRegister();
            frr.Show();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
