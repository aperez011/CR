using CR.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Data
{
    public class dbModelContext : DbContext
    {
        public dbModelContext()
            : base("Name=dbCashRegister")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> User { get; set; }
        public DbSet<Coin> Coins { get; set; }
        public DbSet<CashRegister> CashRegisters { get; set; }
        public DbSet<CashRegisterDetails> CashRegisterDetails { get; set; }
        public DbSet<CashRelation> CashRelations { get; set; }
        public DbSet<CashExpense> CashExpenses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserAdapter());
            modelBuilder.Configurations.Add(new CoinAdapter());
            modelBuilder.Configurations.Add(new CashRegisterAdapter());
            modelBuilder.Configurations.Add(new CashRegisterDetailsAdapter());
            modelBuilder.Configurations.Add(new CashExpenseAdapter());
            modelBuilder.Configurations.Add(new CashRelationAdapter());

            //Cash register relation
            modelBuilder.Entity<CashRegister>()
                        .HasMany<CashRegisterDetails>(g => g.Details)
                        .WithRequired(s => s.CashRegister)
                        .HasForeignKey<int>(s => s.CashRegisterId);
        }
    }
}
