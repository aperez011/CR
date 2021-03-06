﻿using CR.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Data
{
    public class CashRegisterAdapter : EntityTypeConfiguration<CashRegister>
    {
        public CashRegisterAdapter()
        {
            this.HasKey(t => t.Id);

            this.ToTable("CashRegister");
            this.Property(t => t.Id);
            this.Property(t => t.ShiftId);
            this.Property(t => t.DateRegister);
            this.Property(t => t.CashierId);
            this.Property(t => t.TotalAmount);
            this.Property(t => t.RegisterType);
            this.Property(t => t.LogDate);
            this.Property(t => t.IsActive);
        }
    }
}
