using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILogService" in both code and config file together.
    [ServiceContract]
    public interface ILogService
    {
        [OperationContract]
        List<LogSet_SelectResult> GetTopLogs(int count);

        [OperationContract]
        void InsertLog(string NationalCode, string Description);
    }
}
