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
    public class CategoryDAO
    {
        public bool insertCategory(Category category)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("insert [dbo].[CATEGORY] values ('{0}','{1}','{2}')",
                                                  category.Id, category.Name, category.Img));
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
        public DataSet getAllCategory()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; database=Clothes";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [dbo].[CATEGORY]", con);
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

        public bool DeleteCategory(string categoryId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[CATEGORY] where Id='{0}'",
                                                  categoryId));
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

        public bool UpdateCategory(Category category)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Update [dbo].[CATEGORY]" + "set Name='{1}', Img='{2}' where Id='{0}'", category.Id, category.Name, category.Img));

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
        public Category getDetails(string Id)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;User Id=sa; Password=1; Database=Clothes";
                //tim cac nhan vien theo ma phong ban
                SqlCommand cmd = new SqlCommand("select * from [dbo].[CATEGORY] where Id=''" + Id, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Category de = new Category()
                    {
                        Id = Id,
                        Name = dr.GetString(1),
                        Img = dr.GetString(2),
                    };

                    return de;
                }

            }
            catch (Exception ex)
            {
            }

            return null;
        }
    }
}
