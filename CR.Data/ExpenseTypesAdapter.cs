using CR.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Data
{
    public class ExpenseTypesAdapter : EntityTypeConfiguration<ExpenseType>
    {
        public ExpenseTypesAdapter()
        {
            this.HasKey(t => t.Id);

            this.ToTable("ExpenseTypes");
            this.Property(t => t.Id);
            this.Property(t => t.Code);
            this.Property(t => t.Name);
            this.Property(t => t.Description);
            this.Property(t => t.LogDate);
            this.Property(t => t.IsActive);
        }
    }
}
