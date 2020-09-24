using CR.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Data
{
    public class CashExpenseAdapter : EntityTypeConfiguration<CashExpense>
    {

        public CashExpenseAdapter()
        {
            this.HasKey(t => t.Id);

            this.ToTable("CashExpenses");
            this.Property(t => t.Id);
            this.Property(t => t.ExpenseTypeId);
            this.Property(t => t.RegisterDate);
            this.Property(t => t.BillNum);
            this.Property(t => t.BillAmount);
            this.Property(t => t.UserId);
            this.Property(t => t.Reason);
            this.Property(t => t.LastUpdate);
            this.Property(t => t.LogDate);
            this.Property(t => t.IsActive);

        }
    }
}
