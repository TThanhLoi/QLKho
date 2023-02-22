using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfInsuarances.DataContract;

namespace WcfInsuarances
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IInsuaranceService
    {

        [OperationContract]
        List<Import> GetAllImportProcessesById(string Id);
        [OperationContract]
        List<Export> GetAllExportProcessesById(string Id);
    }
}
