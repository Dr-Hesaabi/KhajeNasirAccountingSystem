using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhajeNasirAccountingSystemWcfServiceApplication
{
    public class MainFunctionality
    {
        public void Log(string NationalCode, string Description)
        {
            try
            {
                new DcDataContext().LogSet_Insert(Description, NationalCode);
            }
            catch (Exception e)
            {

                // TODO log exceptions to file system or Windows logs.

            }
        }
    }
}