using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public class CashRegister : EntityBase
    {
        public int CashierId { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid RegisterType { get; set; }
    }
}
