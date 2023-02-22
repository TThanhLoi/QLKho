using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Composition;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfInsuarances.DataContract;

namespace WcfInsuarances
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IInsuaranceService
    {
        public void DoWork()
        {
        }

        public List<DataContract.Export> GetAllExportProcessesById(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Import> GetAllImportProcessesById(string Id)
        {
            List<Import> lst = new List<Import>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.; User Id=sa; Password=1; database=Clothes";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Import where Id='" + Id + "'", con);
            try
            {
                con.Open();
                adapter.Fill(ds);
                con.Close();

                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    Import im  = new Import()
                    {
                        Id = row.ItemArray[0].ToString(),
                        Product_Id = row.ItemArray[1].ToString(),
                        Total = Int32.Parse(row.ItemArray[2].ToString()),
                        Status = row.ItemArray[3].ToString(),
                        UserName = row.ItemArray[4].ToString(),
                        Supplier_Id = row.ItemArray[5].ToString(),
                        Import_Date = DateTime.Parse(row.ItemArray[6].ToString()),
                        Beginning_Inventory = Int32.Parse(row.ItemArray[7].ToString()),
                        Ending_Inventory = Int32.Parse(row.ItemArray[8].ToString()),
                        Import_Quantity = Int32.Parse(row.ItemArray[9].ToString()),
                        Note = row.ItemArray[10].ToString(),
                        Import_Price = Int32.Parse(row.ItemArray[11].ToString())
                  
                    };
                    lst.Add(im);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return lst;
        }
    }
}
