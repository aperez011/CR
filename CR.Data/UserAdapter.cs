using CR.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Data
{
    public class UserAdapter : EntityTypeConfiguration<User>
    {
        public UserAdapter()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.Id);
            this.Property(t => t.UserName);
            this.Property(t => t.Password);
            this.Property(t => t.UserRol);
            this.Property(t => t.IsActive);
            this.Property(t => t.LogDate);

        }
    }
}
