using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfInsuarances.DataContract
{
    public class Export
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
            public string Name_cs { get; set; }
            [DataMember]
            public string Phone_cs { set; get; }
            [DataMember]
            public string address_cs { get; set; }
            [DataMember]
            public DateTime Export_Date { get; set; }
            [DataMember]
            public int Export_Quantity { get; set; }
            [DataMember]
            public string Note { get; set; }
           
            [DataMember]
            public int Beginning_Inventory { get; set; }
            [DataMember]
            public int Ending_Inventory { get; set; }
            [DataMember]
            public int Export_Price { get; set; }

        }
    }
}