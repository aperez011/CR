using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public class CashExpense : EntityBase
    {
        public int ExpenseTypeId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string BillNum { get; set; }
        public decimal BillAmount { get; set; }
        public int UserId { get; set; }
        public string Reason { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ExpenseType ExpenseType { get; set; }
    }
}
