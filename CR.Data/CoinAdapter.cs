using CR.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CR.Data
{
    public class CoinAdapter: EntityTypeConfiguration<Coin>
    {
        public CoinAdapter()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Table & Column Mappings
            this.ToTable("Coins");
            this.Property(t => t.Id);
            this.Property(t => t.Name);
            this.Property(t => t.Description);
            this.Property(t => t.Type);
            this.Property(t => t.IsActive);
            this.Property(t => t.LogDate);

        }
    }
}
