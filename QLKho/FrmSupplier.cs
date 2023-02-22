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
using Google.Apis.Admin.Directory.directory_v1.Data;

namespace QLKho
{
    public partial class FrmSupplier : Form
    {
        private SupplierBUS spBUS = new SupplierBUS();
        private BindingSource bs = new BindingSource();
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            bs.DataSource = spBUS.getAllSupplier().Tables[0];
            gv_list.DataSource = bs;
        }

        private void gv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gv_list.SelectedRows[0].Index;

            string id = gv_list.Rows[index].Cells[0].Value.ToString();
            string name = gv_list.Rows[index].Cells[1].Value.ToString();
            string adrress = gv_list.Rows[index].Cells[2].Value.ToString();
            string url = gv_list.Rows[index].Cells[3].Value.ToString();
            string vat = gv_list.Rows[index].Cells[4].Value.ToString();

            txt_id.Text = id;
            txt_name.Text = name;
            txt_address.Text = adrress;
            txt_url.Text = url;
            txt_vat.Text = vat;
        }
        private void Reset()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_address.Text = "";
            txt_url.Text = "";
            txt_vat.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string address = txt_address.Text;
            string url = txt_url.Text;
            string vat = txt_vat.Text;

            Supplier sp = new Supplier();
            sp.Id = id;
            sp.Name = name;
            sp.Address = address;
            sp.Url = url;
            sp.Vat = vat;

            bool result = spBUS.createSupplier(sp);
            if (result)
            {
                lbl_message.Text = "create successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = spBUS.getAllSupplier().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string name = txt_name.Text;
            string address = txt_address.Text;
            string url = txt_url.Text;
            string vat = txt_vat.Text;

            Supplier sp = new Supplier();
            sp.Id = id;
            sp.Name = name;
            sp.Address = address;
            sp.Url = url;
            sp.Vat = vat;

            bool result = spBUS.UpdateSupplier(sp);
            if (result)
            {
                lbl_message.Text = "create successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = spBUS.getAllSupplier().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // chi xoa nhung phong ban ma co chua nhan vien
            string id = txt_id.Text;
            bool result = spBUS.DeleteSupplier(id);
            if (result)
                lbl_message.Text = "Delete successfully!";
            else
                lbl_message.Text = "Delete fail!";
            //4.load refresh to grid

            bs.DataSource = spBUS.getAllSupplier().Tables[0];
            gv_list.DataSource = bs;
        }
    }
}

