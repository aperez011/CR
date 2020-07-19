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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserAdapter());
            modelBuilder.Configurations.Add(new CoinAdapter());
        }
    }
}
