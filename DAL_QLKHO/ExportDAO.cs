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
    public class ExportDAO
    {
            public bool insertExport(Export export)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
                //insert / update /delete


                SqlCommand sqlCommand = new SqlCommand(string.Format("insert [dbo].[EXPORT] values ('{0}', '{1}', {2}, '{3}', '{4}', '{5}', {6}, '{7}', '{8}', {9}, '{10}', {11}, {12}, {13} )",
                                                      export.Id, export.Product_Id, export.Total, export.Status, export.UserName, export.Name_cs, export.Phone_cs, export.Address_cs, export.Export_Date, export.Export_Quantity, export.Note, export.Beginning_Inventory, export.Ending_Inventory, export.Export_Price));
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
            public DataSet getAllExport()
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.; User Id=sa; Password=1; database=Clothes";
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Export", con);
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

            public bool DeleteExport(string exportId)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
                //insert / update /delete


                SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[Export] where Id='{0}'",
                                                      exportId));
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

            public bool UpdateExport(Export export)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
                //insert / update /delete


                SqlCommand sqlCommand = new SqlCommand(string.Format("Update [dbo].[Export]" + "set Product_Id='{1}', Total={2}, Status='{3}', UserName='{4}', Name_cs='{5}', Phone_cs='{6}', Address_cs='{7}', Export_Date='{8}', Export_Quantity={9}, Note='{10}', Beginning_Inventory={11}, Ending_Inventory={12}, Export_Price={13} where Id='{0}'", export.Id, export.Product_Id, export.Total, export.Status, export.UserName, export.Name_cs, export.Phone_cs, export.Address_cs, export.Export_Date, export.Export_Quantity, export.Note, export.Beginning_Inventory, export.Ending_Inventory, export.Export_Price));

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

