using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {
            SubCategories = new List<SubCategory>();
        }

        public Guid Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Owner { get; set; }

        //[ForeignKey("FK_Category_SubCategory")]
        public ICollection<SubCategory> SubCategories { get; set; }
    }

    public class SubCategory : EntityBase
    {

        public Guid Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Owner { get; set; }

        public virtual Category Category { get; set; }
    }
}
