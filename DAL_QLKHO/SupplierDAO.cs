using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKHO;


namespace DAL_QLKHO
{
    public class SupplierDAO
    {
        public bool insertSupplier(Supplier sp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("insert [dbo].[SUPPLIER] values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                                  sp.Id, sp.Name, sp.Address, sp.Url, sp.Vat));
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
        public DataSet getAllSupplier()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; database=Clothes";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Supplier", con);
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

        public bool DeleteSupplier(string spId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[SUPPLIER] where Id='{0}'",
                                                  spId));
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

        public bool UpdateSupplier(Supplier sp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Update [dbo].[SUPPLIER]" + "set Name='{1}', Address='{2}', Url='{3}', Vat='{4}' where Id='{0}'", sp.Id, sp.Name, sp.Address, sp.Url, sp.Vat));

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
