using CR.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Data
{
    public class CashRelationAdapter : EntityTypeConfiguration<CashRelation>
    {

        public CashRelationAdapter()
        {
            this.HasKey(t=> t.Id);

            this.ToTable("CashRelation");
            this.Property(t => t.Id);
            this.Property(t => t.RegisterDate);
            this.Property(t => t.CashierOpening);
            this.Property(t => t.CashierClosing);
            this.Property(t => t.DayExpenses);
            this.Property(t => t.DayBalance);
            this.Property(t => t.LogDate);
            this.Property(t => t.IsActive);
        }
    }
}
