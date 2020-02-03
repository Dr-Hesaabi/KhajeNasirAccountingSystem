using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhajeNasirAccountingSystemReportClient.MVVM
{
    class DatabaseLogsModel
    {
        public long Id { get; set; }
        public string User { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
    }
    class DatabaseLogs
    {
        static public List<DatabaseLogsModel> Get()
        {
            return new DatabaseLogsService.LogServiceClient().GetTopLogs(1000).Select(x => new DatabaseLogsModel { Id = x.Id, User = x.NationalCode, EventDate = x.EventDateTime, Description = x.Description }).ToList();
        }
    }
}
