using EcommerceWebUILab.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace EcommerceWebUILab.Models.DataContext
{
    public static class DataSeed
    {



        public static IApplicationBuilder Seed(this IApplicationBuilder app)
        {
            //const string adminEmail = "gm@pyramidgroup.az";
            //const string adminPassword = "PyramidimaryP2022100%";
            //const string superAdminRoleName = "SuperAdmin";

            using (var scope = app.ApplicationServices.CreateScope())
            {

                var db = scope.ServiceProvider.GetRequiredService<EcommerceDbContext>();

                //var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();
              

                //var role = roleManager.FindByNameAsync(superAdminRoleName).Result;
                //if (role == null)
                //{
                //    role = new AppRole
                //    {
                //        Name = superAdminRoleName
                //    };

                //    roleManager.CreateAsync(role).Wait();
                //}


                //var userManeger = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

                //var adminUser = userManeger.FindByEmailAsync(adminEmail).Result;

                //if (adminUser == null)
                //{
                //    adminUser = new AppUser
                //    {
                //        Email = adminEmail,
                //        UserName = adminEmail,
                //        EmailConfirmed = true
                //    };

                //    var userResult = userManeger.CreateAsync(adminUser, adminPassword).Result;

                //    if (userResult.Succeeded)
                //    {
                //        userManeger.AddToRoleAsync(adminUser, superAdminRoleName).Wait();
                //    }

                //}

                if (!db.SiteInfo.Any())
                {
                    db.SiteInfo.Add(new SiteInfo
                    {
                        Name = "EShopper",
                        Description = "gedda ga ggerg  ge  egegege gf aergaergaeg  ggere ggegae greg ge",

                    });
                    db.SaveChanges();

                }

            }
            return app;
        }
    }
}
