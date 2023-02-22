using DTO_QLKHO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLKHO
{
    public class ProductDAO
    {
        public bool insertProduct(Product product)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("insert [dbo].[PRODUCT] values ('{0}','{1}', '{2}','{3}','{4}','{5}', '{6}','{7}', '{8}', '{9}', '{10}','{11}','{12}','{13}')",
                                                  product.Id, product.Name, product.PriceIn, product.PriceOut, product.Discount, product.CategoryId, product.Quantity, product.Img, product.Localbrand, product.Size, product.Color, product.DateIn.ToString("yyyy/MM/dd"), product.Description,product.Supplier_Id));
            try
            {
                con.Open();
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataSet getAllProducts()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; database=Clothes";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Product", con);
            try
            {
                con.Open();
                adapter.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }

        public bool DeleteProduct(string productId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[Product] where Id='{0}'",
                                                  productId));
            try
            {
                con.Open();
                sqlCommand.Connection = con;

                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool UpdateProduct(Product product)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Update [dbo].[PRODUCT]" + 
                "set Name='{0}', PriceIn='{1}', PriceOut='{2}', Discount='{3}', Category_Id='{4}',Quantity='{5}',Img='{6}',Localbrand='{7}', Size='{8}', Color='{9}', DateIn='{10}', Description='{11}',Supplier_Id='{12}' where Id='{13}'", 
                product.Name, product.PriceIn, product.PriceOut, product.Discount, product.CategoryId, product.Quantity, product.Img, product.Localbrand, product.Size, product.Color, product.DateIn.ToString("yyyy/MM/dd"), product.Description,product.Supplier_Id,product.Id));

            try
            {
                con.Open();
                sqlCommand.Connection = con;

                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
