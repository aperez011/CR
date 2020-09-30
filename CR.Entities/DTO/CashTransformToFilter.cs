using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities.DTO
{
    public class CashTransformToFilter
    {
        public int Cashier { get; set; }
        public int Shift { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
