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
    public class SupplierBUS
    {
        private SupplierDAO spdao = new SupplierDAO();
        public bool createSupplier(Supplier sp)
        {

            return spdao.insertSupplier(sp);

        }

        public DataSet getAllSupplier()
        {

            return spdao.getAllSupplier();
        }

        public bool UpdateSupplier(Supplier sp)
        {
            return spdao.UpdateSupplier(sp);
        }

        public bool DeleteSupplier(string spId)
        {
            return spdao.DeleteSupplier(spId);
        }
    }
}
