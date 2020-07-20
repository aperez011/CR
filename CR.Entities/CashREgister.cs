using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public class CashRegister : EntityBase
    {
        public CashRegister()
        {
            Details = new List<CashRegisterDetails>();
        }

        public DateTime DateRegister { get; set; }
        public int CashierId { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid RegisterType { get; set; }
        public ICollection<CashRegisterDetails> Details { get; set; }
    }
}
