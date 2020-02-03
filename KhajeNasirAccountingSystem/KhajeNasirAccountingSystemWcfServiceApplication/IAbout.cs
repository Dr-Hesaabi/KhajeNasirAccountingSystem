using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAbout" in both code and config file together.
    [ServiceContract]
    public interface IAbout
    {
        [OperationContract]
        string Hello();
        [OperationContract]
        string HowIsYourDatabase();
    }
}
