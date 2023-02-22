using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLKHO;
using BLL_QLKHO;
namespace QLKho
{
    public partial class FrmRegister : Form
    {
        private BindingSource bs = new BindingSource();
        private UserBUS bus = new UserBUS();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string username = txt_username.Text;
                string password = txt_password.Text;
                string confirmpassword = txt_confirm.Text;
                if (confirmpassword == password)
                {
                    User account = new User()
                    {
                        UserName = username,
                        PassWord = password
                    };
                    //3. call BUS --> insert into db
                    bool result = bus.createUser(account);
                    if (result)
                    {
                        lbl_message.Text = "successfully!!";
                        FrmLogin frl = new FrmLogin();
                        frl.Show();
                        this.Hide();
                    }
                    else
                        lbl_message.Text = "Fail!!";
                }
                else
                    lbl_message.Text = "pass khong trung";
            }
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
  



            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegister_Validating(object sender, CancelEventArgs e)
        {
            string username = txt_username.Text.Trim();
            if (String.IsNullOrEmpty(username))
            {
                //ktra rong
                errorProvider.SetError(txt_username, "Pls. enter id ");
                e.Cancel = true;

            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frl = new FrmLogin();
            frl.Show();
        }
    }
}
