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
using DTO_QLKHO;
namespace QLKho
{
    public partial class FrmCategory : Form
    {
        private CategoryBUS cateBUS = new CategoryBUS();
        private BindingSource bs = new BindingSource();
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            bs.DataSource = cateBUS.getAllCategory().Tables[0];
            gv_list.DataSource = bs;
        }

        private void gv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gv_list.SelectedRows[0].Index;

            string id = gv_list.Rows[index].Cells[0].Value.ToString();
            string name = gv_list.Rows[index].Cells[1].Value.ToString();
            string img = gv_list.Rows[index].Cells[2].Value.ToString();
           

            txt_id.Text = id;
            txt_name.Text = name;
            txt_img.Text = img;
            
        }

        private void Reset()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_img.Text = "";
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string img = txt_img.Text;
            
            Category sp = new Category();
            sp.Id = id;
            sp.Name = name;
            sp.Img = img;

            bool result = cateBUS.createCategory(sp);
            if (result)
            {
                lbl_message.Text = "create successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = cateBUS.getAllCategory().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string img = txt_img.Text;

            Category sp = new Category();
            sp.Id = id;
            sp.Name = name;
            sp.Img = img;

            bool result = cateBUS.UpdateCategory(sp);
            if (result)
            {
                lbl_message.Text = "Update successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = cateBUS.getAllCategory().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // chi xoa nhung phong ban ma co chua nhan vien
            string id = txt_id.Text;
            bool result = cateBUS.DeleteCategory(id);
            if (result)
                lbl_message.Text = "Delete successfully!";
            else
                lbl_message.Text = "Delete fail!";
            //4.load refresh to grid

            bs.DataSource = cateBUS.getAllCategory().Tables[0];
            gv_list.DataSource = bs;
        }

        private void txt_id_Validating(object sender, CancelEventArgs e)
        {
            string Id = txt_id.Text.Trim();
            if (String.IsNullOrEmpty(Id))
            {
                //ktra rong
                errorProvider.SetError(txt_id, "Pls. enter id ");
                e.Cancel = true;

            }
            else
            {

                try
                {
                    string i_id = Id.Trim();
                    //kstra co trong db ??
                    if (cateBUS.checkExistId(i_id))
                    {
                        errorProvider.SetError(txt_id, "id is exist!!");
                        e.Cancel = true;
                    }
                    else
                    {

                        errorProvider.SetError(txt_id, null);
                        e.Cancel = false;
                    }
                }
                catch (Exception ex)
                {
                    errorProvider.SetError(txt_id, "Pls enter id");
                    e.Cancel = true;

                }



            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_SystemColorsChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
