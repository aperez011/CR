using CR.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Data
{
    public class CashRegisterDetailsAdapter : EntityTypeConfiguration<CashRegisterDetails>
    {
        public CashRegisterDetailsAdapter()
        {
            this.HasKey(t => t.Id);

            this.ToTable("CashRegisterDetails");
            this.Property(t => t.Id);
            this.Property(t => t.CashRegisterId);
            this.Property(t => t.CoinId);
            this.Property(t => t.CoinAmount);
            this.Property(t => t.RefNUmber);
            this.Property(t => t.TotalAmount);
            this.Property(t => t.LogDate);
            this.Property(t => t.IsActive);
        }
    }
}
