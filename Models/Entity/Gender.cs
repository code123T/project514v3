using System.Collections;
using System.Collections.Generic;

namespace EcommerceWebUILab.Models.Entity
{
    public class Gender : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
