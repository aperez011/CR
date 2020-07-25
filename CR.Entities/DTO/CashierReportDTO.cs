using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities.DTO
{
    public class CashierReportDTO
    {
        public string UserName { get; set; }
        public string Date { get; set; }
        public string OpenAmount { get; set; }
        public string CloseAmount { get; set; }
        public string ExpensesAmount { get; set; }
        public string CashBalance { get; set; }
    }

    public class BalanceDetails
    {
        public string OpenCash { get; set; }
        public string OpenCards { get; set; }
        public string OpenDeposit { get; set; }
        public string OpenTransfer { get; set; }
        public string OpenCredit { get; set; }
        public string CloseCash { get; set; }
        public string CloseCards { get; set; }
        public string CloseDeposit { get; set; }
        public string CloseTransfer { get; set; }
        public string CloseCredit { get; set; }
    }
}
