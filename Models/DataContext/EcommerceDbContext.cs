
using EcommerceWebUILab.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Xml.Linq;

namespace EcommerceWebUILab.Models.DataContext { 

    public class EcommerceDbContext:DbContext
    {

        public EcommerceDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public DbSet<SiteInfo> SiteInfo { get; set; }
        public DbSet<Campaign> Campaign { get; set; }
        public DbSet<SiteSocialLinks> SocialLinks { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
}
