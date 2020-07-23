using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public class CashRelation : EntityBase
    {
        public DateTime RegisterDate { get; set; }
        public decimal CashierOpening { get; set; }
        public decimal CashierClosing { get; set; }
        public decimal DayExpenses { get; set; }
        public decimal DayBalance { get; set; }
    }
}
