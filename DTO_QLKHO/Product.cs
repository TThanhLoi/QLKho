using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKHO
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int PriceIn { get; set; }
        public int PriceOut { get; set; }
        public int Discount { get; set; }
        public string CategoryId { get; set; }
        public int Quantity { get; set; }
        public string Img { get; set; }
        public string Localbrand { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public DateTime DateIn { get; set; }
        public string Description { get; set; }
        public string Supplier_Id { get; set; }

        public Product()
        {

        }
    }
}
