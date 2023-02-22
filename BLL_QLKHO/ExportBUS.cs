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
    public class ExportBUS
    {
        private ExportDAO exdao = new ExportDAO();
        public bool createExport(Export ex)
        {
            return exdao.insertExport(ex);
        }

        public DataSet getAllExport()
        {

            return exdao.getAllExport();
        }

        public bool UpdateExport(Export ex)
        {
            return exdao.UpdateExport(ex);
        }

        public bool DeleteExport(string exId)
        {
            return exdao.DeleteExport(exId);
        }
    }
}
