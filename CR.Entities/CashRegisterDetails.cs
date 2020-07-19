using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public class CashRegisterDetails : EntityBase
    {
        public int CashRegisterId { get; set; }
        public int CoinId { get; set; }
        public int CoinAmount { get; set; }
        public string RefNUmber { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
