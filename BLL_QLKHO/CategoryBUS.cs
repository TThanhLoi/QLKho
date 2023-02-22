using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLKHO;
using DTO_QLKHO;

namespace BLL_QLKHO
{
    public class CategoryBUS
    {
        private CategoryDAO dao = new CategoryDAO();
        public bool createCategory(Category category)
        {

            return dao.insertCategory(category);

        }
        public bool checkExistId(string Id)
        {
            Category cate = dao.getDetails(Id);
            return cate ==null ? false : true;  
        }

        public DataSet getAllCategory()
        {

            return dao.getAllCategory();
        }

        public bool UpdateCategory(Category category)
        {
            return dao.UpdateCategory(category);
        }

        public bool DeleteCategory(string categoryId)
        {
            return dao.DeleteCategory(categoryId);
        }
    }
}
