using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LogService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LogService.svc or LogService.svc.cs at the Solution Explorer and start debugging.
    public class LogService : ILogService
    {
        DcDataContext dc = new DcDataContext();
        public List<LogSet_SelectResult> GetTopLogs(int count = 100)
        {
            return dc.LogSet_Select().OrderByDescending(x => x.EventDateTime).Take(count).ToList();
        }
        public void InsertLog(string NationalCode, string Description)
        {
            new MainFunctionality().Log(NationalCode, Description);
        }


    }
}
