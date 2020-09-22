using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public class ExpenseType : EntityBase
    {
        public ExpenseType()
        {
            LogDate = DateTime.Now;
            IsActive = true;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
