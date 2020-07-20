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
        static dbModelContext()
        {
            Database.SetInitializer<dbModelContext>(null);
        }

        public dbModelContext()
            : base("Name=dbCashRegister")
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Coin> Coins { get; set; }
        public DbSet<CashRegister> CashRegisters { get; set; }
        public DbSet<CashRegisterDetails> CashRegisterDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserAdapter());
            modelBuilder.Configurations.Add(new CoinAdapter());
            modelBuilder.Configurations.Add(new CashRegisterAdapter());
            modelBuilder.Configurations.Add(new CashRegisterDetailsAdapter());

            modelBuilder.Entity<CashRegister>()
                        .HasMany<CashRegisterDetails>(g => g.Details)
                        .WithRequired(s => s.CashRegister)
                        .HasForeignKey<int>(s => s.CashRegisterId);
        }
    }
}
