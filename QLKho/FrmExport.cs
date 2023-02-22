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
    public partial class FrmExport : Form
    {
        private ExportBUS exBuS = new ExportBUS();
        private ProductBUS proBuS = new ProductBUS();
        private BindingSource bs = new BindingSource();
        public FrmExport()
        {
            InitializeComponent();
        }

        private void FrmExport_Load(object sender, EventArgs e)
        {
            bs.DataSource = exBuS.getAllExport().Tables[0];
            gv_list.DataSource = bs;

            cbx_product.DataSource = proBuS.getAllProducts().Tables[0];
            cbx_product.DisplayMember = "Name";
            cbx_product.ValueMember = "Id";
        }

        private void gv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gv_list.SelectedRows[0].Index;

            string id = gv_list.Rows[index].Cells[0].Value.ToString();
            string product = gv_list.Rows[index].Cells[1].Value.ToString();
            string total = gv_list.Rows[index].Cells[2].Value.ToString();
            string status = gv_list.Rows[index].Cells[3].Value.ToString();
            string username = gv_list.Rows[index].Cells[4].Value.ToString();
            string namecs = gv_list.Rows[index].Cells[5].Value.ToString();
            string phonecs = gv_list.Rows[index].Cells[6].Value.ToString();
            string addresscs = gv_list.Rows[index].Cells[7].Value.ToString();
            string importdate = gv_list.Rows[index].Cells[8].Value.ToString();
            string quantity = gv_list.Rows[index].Cells[9].Value.ToString();
            string note = gv_list.Rows[index].Cells[10].Value.ToString();
            string begininventory = gv_list.Rows[index].Cells[11].Value.ToString();
            string endinventory = gv_list.Rows[index].Cells[12].Value.ToString();
            string price = gv_list.Rows[index].Cells[13].Value.ToString();



            DateTime dt_date = DateTime.Parse(importdate);

            Export export = new Export();
            {
                txt_id.Text = id;
                cbx_product.SelectedValue = product;
                txt_namecs.Text = namecs;
                txt_phonecs.Text = phonecs;
                txt_address.Text = addresscs;
                txt_total.Text = total;
                txt_price.Text = price;
                txt_quantity.Text = quantity;
                txt_note.Text = note;
                txt_status.Text = status;
                txt_username.Text = username;
                txt_begininventory.Text = begininventory;
                txt_endinventory.Text = endinventory;
                dtp_export.Value = dt_date;
            }
        }
        private void Reset()
        {
            txt_id.Text = "";
            cbx_product.SelectedIndex = 0;
            txt_namecs.Text = "";
            txt_phonecs.Text = "";
            txt_address.Text = "";
            txt_total.Text = "";
            txt_status.Text = "";
            txt_username.Text = "";
            txt_begininventory.Text = "";
            txt_endinventory.Text = "";
            txt_quantity.Text = "";
            txt_note.Text = "";
            txt_price.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            int total = Int32.Parse(txt_total.Text);
            string status = txt_status.Text;
            string username = txt_username.Text;
            DateTime exportdate = dtp_export.Value;
            int begininventory = Int32.Parse(txt_begininventory.Text);
            int endinventory = Int32.Parse(txt_endinventory.Text);
            int quantity = Int32.Parse(txt_quantity.Text);
            int price = Int32.Parse(txt_price.Text);
            string note = txt_note.Text;
            string namecs = txt_namecs.Text;
            int phonecs = Int32.Parse(txt_phonecs.Text);
            string addresscs = txt_address.Text;
            //combobox
            string product = cbx_product.SelectedValue.ToString();
            




            //datetimepicker

            //2. tao DTO
            Export export = new Export()
            {
                Id = id,
                Total = total,
                Status = status,
                UserName = username,
                Export_Date = exportdate,
                Beginning_Inventory = begininventory,
                Ending_Inventory = endinventory,
                Export_Quantity = quantity,
                Export_Price = price,
                Note = note,
                Product_Id = product,
                Name_cs = namecs,
                Phone_cs=phonecs,
                Address_cs=addresscs
                                
            };
            //3. CALL bus => insert into db
            bool result = exBuS.createExport(export);
            if (result)
            {
                lbl_message.Text = "create successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = exBuS.getAllExport().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            int total = Int32.Parse(txt_total.Text);
            string status = txt_status.Text;
            string username = txt_username.Text;
            DateTime exportdate = dtp_export.Value;
            int begininventory = Int32.Parse(txt_begininventory.Text);
            int endinventory = Int32.Parse(txt_endinventory.Text);
            int quantity = Int32.Parse(txt_quantity.Text);
            int price = Int32.Parse(txt_price.Text);
            string note = txt_note.Text;
            string namecs = txt_namecs.Text;
            int phonecs = Int32.Parse(txt_phonecs.Text);
            string addresscs = txt_address.Text;
            //combobox
            string product = cbx_product.SelectedValue.ToString();





            //datetimepicker

            //2. tao DTO
            Export export = new Export()
            {
                Id = id,
                Total = total,
                Status = status,
                UserName = username,
                Export_Date = exportdate,
                Beginning_Inventory = begininventory,
                Ending_Inventory = endinventory,
                Export_Quantity = quantity,
                Export_Price = price,
                Note = note,
                Product_Id = product,
                Name_cs = namecs,
                Phone_cs = phonecs,
                Address_cs = addresscs

            };
            //3. CALL bus => insert into db
            bool result = exBuS.UpdateExport(export);
            if (result)
            {
                lbl_message.Text = "Update successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = exBuS.getAllExport().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //chi xoa nhung phong ban ma co chua nhan vien
            string id = txt_id.Text;
            bool result = exBuS.DeleteExport(id);
            if (result)
            {
                lbl_message.Text = "Delete  successfully!";
                Reset();
            }
            else
                lbl_message.Text = "Delete  fail!";
            //4.load refresh to grid

            bs.DataSource = exBuS.getAllExport().Tables[0];
            gv_list.DataSource = bs;
        }
    }
}
