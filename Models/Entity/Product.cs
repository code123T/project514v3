using System;

namespace EcommerceWebUILab.Models.Entity
{
    public class Product : BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public int GenderId { get; set; }

        public Gender Gender { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int CampaignId { get; set; }

        public Campaign Campaign { get; set; }


    }
}
