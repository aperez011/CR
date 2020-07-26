using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities.DTO
{
    public class ReportDTO
    {
        public ReportDTO()
        {
            Header = new CashierReportDTO();
            DetailResume = new BalanceDetails();
        }

        public CashierReportDTO Header { get; set; }
        public BalanceDetails DetailResume { get; set; }
    }
}
