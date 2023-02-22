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
    public class ImportDAO
    {
        public bool insertImport(Import import)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("insert [dbo].[Import] values ('{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}', {7}, {8}, {9}, '{10}', {11} )",
                                                  import.Id, import.Product_Id, import.Total, import.Status, import.UserName, import.Supplier_Id, import.Import_Date, import.Beginning_Inventory, import.Ending_Inventory, import.Import_Quantity, import.Note, import.Import_Price));
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
        public DataSet getAllImport()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; database=Clothes";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Import", con);
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

        public bool Deleteimport(string importId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[Import] where Id='{0}'",
                                                  importId));
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

        public bool UpdateImport(Import import)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Update [dbo].[Import]" + "set Product_Id='{1}', Total={2}, Status='{3}', UserName='{4}', Supplier_Id='{5}', Import_Date='{6}', Beginning_Inventory={7}, Ending_Inventory={8}, import_Quantity={9}, Note='{10}', import_Price={11} where Id='{0}'", import.Id, import.Product_Id, import.Total, import.Status, import.UserName, import.Supplier_Id, import.Import_Date.ToString("yyyy/MM/dd"), import.Beginning_Inventory, import.Ending_Inventory, import.Import_Quantity, import.Note, import.Import_Price));

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

