using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKHO
{
    public class Export
    {
        public string Id { get; set; }
        public string Product_Id { get; set; }
        public int Total { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string Name_cs { get; set; }
        public int Phone_cs { get; set; }
        public string Address_cs { get; set; }
        public DateTime Export_Date { get; set; }
        public int Export_Quantity { get; set; }
        public string Note { get; set; }
        public int Beginning_Inventory { get; set; }
        public int Ending_Inventory { get; set; }
        public int Export_Price { get; set; }
        public Export()
        {

        }
    }
}
