using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public partial class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime LogDate { get; set; }
        public bool IsActive { get; set; }
    }
}
