using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "About" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select About.svc or About.svc.cs at the Solution Explorer and start debugging.
    public class About : IAbout
    {
        public string Hello()
        {
            return "Hello World! We are here.";
        }
        public string HowIsYourDatabase()
        {
            try
            {
                var logs = new DcDataContext().LogSet_Select().Take(1).FirstOrDefault().Id;
                return "Its healthy :)";
            }
            catch
            {
                return "Its DOWN";
            }
        }
    }
}
