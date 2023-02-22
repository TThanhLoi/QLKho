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
    public partial class FrmImport : Form
    {
        private ImportBUS imBuS = new ImportBUS();
        private ProductBUS proBuS = new ProductBUS();
        private SupplierBUS spBuS = new SupplierBUS();
        private BindingSource bs = new BindingSource();
        public FrmImport()
        {
            InitializeComponent();
        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }

        private void txt_address_EditValueChanged(object sender, EventArgs e)
        {

        }   
        private void Reset()
        {
            txt_id.Text = "";
            cbx_product.SelectedIndex = 0;
            cbx_supplier.SelectedIndex = 0;
            txt_total.Text = "";
            txt_status.Text = "";
            txt_username.Text = "";
            txt_begininventory.Text = "";
            txt_endinventory.Text = "";
            txt_quantity.Text = "";
            txt_note.Text = "";
            txt_price.Text = "";
        }

        private void FrmImport_Load(object sender, EventArgs e)
        {
            bs.DataSource = imBuS.getAllImport().Tables[0];
            gv_list.DataSource = bs;

            cbx_product.DataSource = proBuS.getAllProducts().Tables[0];
            cbx_product.DisplayMember = "Name";
            cbx_product.ValueMember = "Id";

            cbx_supplier.DataSource = spBuS.getAllSupplier().Tables[0];
            cbx_supplier.DisplayMember = "Name";
            cbx_supplier.ValueMember = "Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            int total = Int32.Parse(txt_total.Text);
            string status = txt_status.Text;
            string username = txt_username.Text;
            DateTime importdate = dtp_import.Value;
            int begininventory = Int32.Parse(txt_begininventory.Text);
            int endinventory = Int32.Parse(txt_endinventory.Text);
            int quantity = Int32.Parse(txt_quantity.Text);
            int price = Int32.Parse(txt_price.Text);
            string note = txt_note.Text;
            //combobox
            string product = cbx_product.SelectedValue.ToString();
            string supplier = cbx_supplier.SelectedValue.ToString();



            //datetimepicker

            //2. tao DTO
            Import import = new Import()
            {
                Id = id,
                Total = total,
                Status = status,
                UserName = username,
                Import_Date = importdate,
                Beginning_Inventory = begininventory,
                Ending_Inventory = endinventory,
                Import_Quantity = quantity,
                Import_Price = price,
                Note = note,
                Product_Id = product,
                Supplier_Id = supplier,
            };
            //3. CALL bus => insert into db
            bool result = imBuS.createImport(import);
            if (result)
            {
                lbl_message.Text = "create successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = imBuS.getAllImport().Tables[0];
            gv_list.DataSource = bs;
        }

        private void gv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gv_list.SelectedRows[0].Index;

            string id = gv_list.Rows[index].Cells[0].Value.ToString();
            string product = gv_list.Rows[index].Cells[1].Value.ToString();
            string total = gv_list.Rows[index].Cells[2].Value.ToString();
            string status = gv_list.Rows[index].Cells[3].Value.ToString();
            string username = gv_list.Rows[index].Cells[4].Value.ToString();
            string supplier = gv_list.Rows[index].Cells[5].Value.ToString();
            string importdate = gv_list.Rows[index].Cells[6].Value.ToString();
            string begininventory = gv_list.Rows[index].Cells[7].Value.ToString();
            string endinventory = gv_list.Rows[index].Cells[8].Value.ToString();
            string quantity = gv_list.Rows[index].Cells[9].Value.ToString();
            string note = gv_list.Rows[index].Cells[10].Value.ToString();
            string price = gv_list.Rows[index].Cells[11].Value.ToString();
            

            DateTime dt_date = DateTime.Parse(importdate);

            Import import = new Import();
            {
                txt_id.Text = id;
                cbx_product.SelectedValue = product;
                cbx_supplier.SelectedValue = supplier;
                txt_total.Text = total;
                txt_price.Text = price;
                txt_quantity.Text = quantity;
                txt_note.Text = note;
                txt_status.Text = status;
                txt_username.Text = username;
                txt_begininventory.Text = begininventory;
                txt_endinventory.Text = endinventory;
                dtp_import.Value = dt_date;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            int total = Int32.Parse(txt_total.Text);
            string status = txt_status.Text;
            string username = txt_username.Text;
            DateTime importdate = dtp_import.Value;
            int begininventory = Int32.Parse(txt_begininventory.Text);
            int endinventory = Int32.Parse(txt_endinventory.Text);
            int quantity = Int32.Parse(txt_quantity.Text);
            int price = Int32.Parse(txt_price.Text);
            string note = txt_note.Text;
            //combobox
            string product = cbx_product.SelectedValue.ToString();
            string supplier = cbx_supplier.SelectedValue.ToString();



            //datetimepicker

            //2. tao DTO
            Import import = new Import()
            {
                Id = id,
                Total = total,
                Status = status,
                UserName = username,
                Import_Date = importdate,
                Beginning_Inventory = begininventory,
                Ending_Inventory = endinventory,
                Import_Quantity = quantity,
                Import_Price = price,
                Note = note,
                Product_Id = product,
                Supplier_Id = supplier,
            };
            //3. CALL bus => insert into db
            bool result = imBuS.Updateimport(import);
            if (result)
            {
                lbl_message.Text = "Update successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = imBuS.getAllImport().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //chi xoa nhung phong ban ma co chua nhan vien
            string id = txt_id.Text;
            bool result = imBuS.Deleteimport(id);
            if (result)
            {
                lbl_message.Text = "Delete  successfully!";
                Reset();
            }
            else
                lbl_message.Text = "Delete  fail!";
            //4.load refresh to grid

            bs.DataSource = imBuS.getAllImport().Tables[0];
            gv_list.DataSource = bs;
        }
    }
}
