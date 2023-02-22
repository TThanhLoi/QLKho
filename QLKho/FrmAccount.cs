using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLKHO;
using BLL_QLKHO;
using System.Net.NetworkInformation;
using DevExpress.XtraPrinting.Export.Pdf;

namespace QLKho
{
    public partial class FrmAccount : Form
    {
        private UserBUS usBUS = new UserBUS();
        private BindingSource bs = new BindingSource();
        public FrmAccount()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gv_list.SelectedRows[0].Index;

            string username = gv_list.Rows[index].Cells[0].Value.ToString();
            string password = gv_list.Rows[index].Cells[1].Value.ToString();
            string role = gv_list.Rows[index].Cells[2].Value.ToString();

            txt_username.Text = username;
            txt_password.Text = password;
            txt_role.Text = role;
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            bs.DataSource = usBUS.getAllUser().Tables[0];
            gv_list.DataSource = bs;
        }
        private void Reset()
        {
            txt_username.Text = "";
            txt_password.Text = "";
            txt_role.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string role = txt_role.Text;

            User us= new User();
            us.UserName = username;
            us.PassWord = password;
            us.Role=role;

            bool result = usBUS.createUser(us);
            if (result) 
            { 
                lbl_message.Text = "create successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = usBUS.getAllUser().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string role = txt_role.Text;

            User us = new User();
            us.UserName = username;
            us.PassWord = password;
            us.Role = role;

            bool result = usBUS.UpdateUser(us);
            if (result)
            {
                lbl_message.Text = "Update successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = usBUS.getAllUser().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // chi xoa nhung phong ban ma co chua nhan vien
            string username = txt_username.Text;
            bool result = usBUS.DeleteUser(username);
            if (result)
                lbl_message.Text = "Delete successfully!";
            else
                lbl_message.Text = "Delete fail!";
            //4.load refresh to grid

            bs.DataSource = usBUS.getAllUser().Tables[0];
            gv_list.DataSource = bs;
        }
    }
}
