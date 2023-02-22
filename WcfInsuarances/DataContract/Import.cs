using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfInsuarances.DataContract
{
    [DataContract]
    public class Import
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Product_Id { get; set; }
        [DataMember]
        public int Total { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Supplier_Id { get; set; }
        [DataMember]
        public DateTime Import_Date { get; set; }
        [DataMember]
        public int Beginning_Inventory { get; set; }
        [DataMember]
        public int Ending_Inventory { get; set; }
        [DataMember]
        public int Import_Quantity { get; set; }
        [DataMember]
        public string Note { get; set; }
        [DataMember]
        public int Import_Price { get; set; }

    }
}