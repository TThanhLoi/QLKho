using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKHO;


namespace DAL_QLKHO
{
    public class UserDAO
    {
        public bool insertUser(User us)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("insert [dbo].[USER] values ('{0}', '{1}', '{2}')",
                                                  us.UserName, GetMD5(us.PassWord), us.Role));
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
        public DataSet getAllUser()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; database=Clothes";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [dbo].[USER]", con);
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

        public bool DeleteUser(string userName)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[USER] where UserName='{0}'",
                                                  userName));
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

        public bool UpdateUser(User us)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; Database=Clothes";
            //insert / update /delete


            SqlCommand sqlCommand = new SqlCommand(string.Format("Update [dbo].[USER]" + "set PassWord='{1}', Role='{2}' where UserName='{0}'", us.UserName, us.PassWord, us.Role));

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

        public User getDetails(string username, string password)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;User Id=sa; Password=1; database=Clothes";
                //tim cac nhan vien theo ma phong ban
                SqlCommand cmd = new SqlCommand("select * from [dbo].[USER] where UserName='" + username+"'and PassWord='"+GetMD5(password)+ "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    User us = new User()
                    {
                        UserName = username,
                        PassWord = password,
                        Role = dr.GetString(2)
                    };

                    return us;
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }
        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
    }
}
