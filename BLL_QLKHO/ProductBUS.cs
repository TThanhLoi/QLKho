using DAL_QLKHO;
using DTO_QLKHO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_QLKHO
{
    public class ProductBUS
    {
        private ProductDAO dao = new ProductDAO();
        public bool createProduct(Product product)
        {
            return dao.insertProduct(product);
        }

        public DataSet getAllProducts()
        {

            return dao.getAllProducts();
        }

        public bool UpdateProduct(Product product)
        {
            return dao.UpdateProduct(product);
        }

        public bool DeleteProduct(string productId)
        {
            return dao.DeleteProduct(productId);
        }
    }
}
