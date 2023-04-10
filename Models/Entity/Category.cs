using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EcommerceWebUILab.Models.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
