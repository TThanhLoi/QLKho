using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKHO
{
    public class Import
    {
        public string Id { get; set; }
        public string Product_Id { get; set; }
        public int Total { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string Supplier_Id { get; set; }
        public DateTime Import_Date { get; set; }
        public int Beginning_Inventory { get; set; }
        public int Ending_Inventory { get; set; }
        public int Import_Quantity { get; set; }
        public string Note { get; set; }
        public int Import_Price { get; set; }
        public Import()
        {

        }
    }
}
