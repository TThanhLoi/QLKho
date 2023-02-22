using DAL_QLKHO;
using DTO_QLKHO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace BLL_QLKHO
{
    public class UserBUS
    {
        private UserDAO usdao = new UserDAO();
        public bool createUser(User us)
        {
            return usdao.insertUser(us);
        }

        public DataSet getAllUser()
        {

            return usdao.getAllUser();
        }

        public bool UpdateUser(User us)
        {
            return usdao.UpdateUser(us);
        }

        public bool DeleteUser(string usId)
        {
            return usdao.DeleteUser(usId);
        }

        public bool checkUserName(string username, string password)
        {
            User ac = usdao.getDetails(username, password);
            if (ac != null)
            {
                if (ac.PassWord == password)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
