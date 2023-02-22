using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL_QLKHO;
using DTO_QLKHO;
using BLL_QLKHO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace QLKho
{
    public partial class Frm_product : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ProductBUS proBUS = new ProductBUS();
        private CategoryBUS cateBUS = new CategoryBUS();
        private SupplierBUS supplierBUS = new SupplierBUS();
        private BindingSource bs = new BindingSource();
        public Frm_product()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bs.DataSource = proBUS.getAllProducts().Tables[0];
            gv_list.DataSource = bs;

            cbx_category.DataSource = cateBUS.getAllCategory().Tables[0];
            cbx_category.DisplayMember = "Name";
            cbx_category.ValueMember = "Id";

            cbx_supplier.DataSource = supplierBUS.getAllSupplier().Tables[0];
            cbx_supplier.DisplayMember = "Name";
            cbx_supplier.ValueMember = "Id";
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //1. lay gia tri cua form
            string proId = txt_id.Text;
            string proName = txt_name.Text;
            int proPriceIn = Int32.Parse(txt_pricein.Text);
            int proPriceOut = Int32.Parse(txt_priceout.Text);
            int proDiscount = Int32.Parse(txt_discount.Text);
            int proQuantity = Int32.Parse(txt_quantity.Text);
            string proImg = lbl_path.Text;
            string proLocalbrand = txt_localbrand.Text;
            string proSize = txt_size.Text;
            string proColor = txt_color.Text;
            string proDescription = txt_description.Text;
            //string proSupplier_Id = txt_supplier.Text;

            //combobox
            string Category_Id = cbx_category.SelectedValue.ToString();
            string Supplier_Id = cbx_supplier.SelectedValue.ToString();
            //datetimepicker
            DateTime joinDate = dtp_date.Value;
            //2. tao DTO
            Product product = new Product()
            {
                Id = proId,
                Name = proName,
                PriceIn = proPriceIn,
                PriceOut = proPriceOut,
                Discount = proDiscount,
                CategoryId = Category_Id,
                Quantity = proQuantity,
                Localbrand = proLocalbrand,
                Size = proSize,
                Color = proColor,
                Description = proDescription,
                DateIn = joinDate,
                Supplier_Id= Supplier_Id,
                Img= proImg,
            };

            string rootPath = Application.StartupPath;
            string uploadPath = @"../../upload/";
            try
            {
                File.Copy(dlg_openfile.FileName, uploadPath + dlg_openfile.SafeFileName);
                lbl_message.Text = "Upload image successfully!";
            }
            catch (Exception ex)
            {

            }

            //3. CALL bus => insert into db
            bool result = proBUS.createProduct(product);
            if (result)
            {
                lbl_message.Text = "create successfully!!!";
                Reset();
            }
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = proBUS.getAllProducts().Tables[0];
            gv_list.DataSource = bs;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //chi xoa nhung phong ban ma co chua nhan vien
            string proId = txt_id.Text;
            bool result = proBUS.DeleteProduct(proId);
            if (result)
                lbl_message.Text = "Delete department successfully!";
            else
                lbl_message.Text = "Delete department fail!";
            //4.load refresh to grid

            bs.DataSource = proBUS.getAllProducts().Tables[0];
            gv_list.DataSource = bs;
        }

        private void gv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gv_list.SelectedRows[0].Index;

            string proId = gv_list.Rows[index].Cells[0].Value.ToString();
            string proName = gv_list.Rows[index].Cells[1].Value.ToString();
            string proPriceIn = gv_list.Rows[index].Cells[2].Value.ToString();
            string proPriceOut = gv_list.Rows[index].Cells[3].Value.ToString();
            string proDiscount = gv_list.Rows[index].Cells[4].Value.ToString();
            string proCategoryId = gv_list.Rows[index].Cells[5].Value.ToString();
            string proQuantity = gv_list.Rows[index].Cells[6].Value.ToString();
            string proImg = gv_list.Rows[index].Cells[7].Value.ToString();
            string proLocalbrand = gv_list.Rows[index].Cells[8].Value.ToString();
            string proSize = gv_list.Rows[index].Cells[9].Value.ToString();
            string proColor = gv_list.Rows[index].Cells[10].Value.ToString();
            string proDateIn = gv_list.Rows[index].Cells[11].Value.ToString();
            string proSupplier = gv_list.Rows[index].Cells[13].Value.ToString();

            DateTime dt_proDateIn = DateTime.Parse(proDateIn);

            string proDescription = gv_list.Rows[index].Cells[12].Value.ToString();

            txt_id.Text = proId;
            txt_name.Text = proName;
            txt_pricein.Text = proPriceIn;
            txt_priceout.Text = proPriceOut;
            txt_discount.Text = proDiscount;
            cbx_category.SelectedValue = proCategoryId;
            txt_quantity.Text = proQuantity;
            txt_localbrand.Text = proLocalbrand;
            txt_size.Text = proSize;
            txt_color.Text = proColor;
            dtp_date.Value = dt_proDateIn;
            txt_description.Text = proDescription;
            dtp_date.Value = dt_proDateIn;
            cbx_supplier.SelectedValue = proSupplier;

            MessageBox.Show("index" + index);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //1. lay gia tri cua form
            string proId = txt_id.Text;
            string proName = txt_name.Text;
            int proPriceIn = Int32.Parse(txt_pricein.Text);
            int proPriceOut = Int32.Parse(txt_priceout.Text);
            int proDiscount = Int32.Parse(txt_discount.Text);
            int proQuantity = Int32.Parse(txt_quantity.Text);
            string proImg = lbl_path.Text;
            string proLocalbrand = txt_localbrand.Text;
            string proSize = txt_size.Text;
            string proColor = txt_color.Text;
            string proDescription = txt_description.Text;
            //string proSupplier_Id = txt_supplier.Text;

            //combobox
            string Category_Id = cbx_category.SelectedValue.ToString();
            string Supplier_Id = cbx_supplier.SelectedValue.ToString();
            //datetimepicker
            DateTime joinDate = dtp_date.Value;
            //2. tao DTO
            Product product = new Product()
            {
                Id = proId,
                Name = proName,
                PriceIn = proPriceIn,
                PriceOut = proPriceOut,
                Discount = proDiscount,
                CategoryId = Category_Id,
                Quantity = proQuantity,
                Localbrand = proLocalbrand,
                Size = proSize,
                Color = proColor,
                Description = proDescription,
                DateIn = joinDate,
                Supplier_Id= Supplier_Id,
                Img = proImg
            };

            string rootPath = Application.StartupPath;
            string uploadPath = @"../../upload/";
            try
            {
                File.Copy(dlg_openfile.FileName, uploadPath + dlg_openfile.SafeFileName);
                lbl_message.Text = "Upload image successfully!";
            }
            catch (Exception ex)
            {

            }
            //3. CALL bus => insert into db
            bool result = proBUS.UpdateProduct(product);
            if (result)
                lbl_message.Text = "create successfully!!!";
            else
                lbl_message.Text = "wrong!! Dont Cry :))";

            //4. Load refresh to grid
            bs.DataSource = proBUS.getAllProducts().Tables[0];
            gv_list.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //Nếu bấm Yes-->đóng chương trình
            if (thoat == DialogResult.Yes)
            {
                this.Close();
                FrmMain frm = new FrmMain();
                frm.ShowDialog();
            }

        }
        private void Reset()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_pricein.Text = "";
            txt_priceout.Text = "";
            txt_discount.Text = "";
            cbx_category.Text = "";
            txt_quantity.Text = "";
            txt_localbrand.Text = "";
            txt_size.Text = "";
            txt_color.Text = "";
            txt_description.Text = "";
            dtp_date.Text = "";
            cbx_supplier.Text = "";
            
        }

        private void txt_name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_size_Click(object sender, EventArgs e)
        {

        }

        private void txt_size_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pricein_Click(object sender, EventArgs e)
        {

        }

        private void txt_pricein_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_discount_Click(object sender, EventArgs e)
        {

        }

        private void pnl_browseupload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if(dlg_openfile.ShowDialog() == DialogResult.OK)
            {
                lbl_path.Text = dlg_openfile.FileName;
                pic_img.ImageLocation = dlg_openfile.FileName;
            }
        }

        private void pic_img_Click(object sender, EventArgs e)
        {
            if (dlg_openfile.ShowDialog() == DialogResult.OK)
            {
                lbl_path.Text = dlg_openfile.FileName;
                pic_img.ImageLocation = dlg_openfile.FileName;
                //txt_img.Text = dlg_openfile.FileName;
            }
        }
    }
}
