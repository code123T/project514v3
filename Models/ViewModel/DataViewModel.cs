using EcommerceWebUILab.Models.Entity;
using System.Collections.Generic;

namespace EcommerceWebUILab.Models.ViewModel
{
    public class DataViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Gender> Genders { get; set; }
        public IEnumerable<SiteInfo> SiteInfo { get; set; }
        public IEnumerable<SiteSocialLinks> SiteSocialLinks { get; set; }
        public IEnumerable<Campaign> Campaigns { get; set; }
    }
}
