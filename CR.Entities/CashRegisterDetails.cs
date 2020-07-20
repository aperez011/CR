using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public class CashRegisterDetails : EntityBase
    {
        [ForeignKey("CashRegister")]
        public int CashRegisterId { get; set; }
        public int CoinId { get; set; }
        public int CoinAmount { get; set; }
        public string RefNUmber { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual CashRegister CashRegister { get; set; }
    }
}
