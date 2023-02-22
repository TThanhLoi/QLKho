using DAL_QLKHO;
using DTO_QLKHO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BLL_QLKHO
{
    public class ImportBUS
    {
        private ImportDAO imdao = new ImportDAO();
        public bool createImport(Import import)
        {
            return imdao.insertImport(import);
        }

        public DataSet getAllImport()
        {

            return imdao.getAllImport();
        }

        public bool Updateimport(Import im)
        {
            return imdao.UpdateImport(im);
        }

        public bool Deleteimport(string imId)
        {
            return imdao.Deleteimport(imId);
        }
    }
}
