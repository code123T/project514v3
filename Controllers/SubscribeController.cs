using EcommerceWebUILab.Models.DataContext;
using EcommerceWebUILab.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebUILab.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly EcommerceDbContext db;
        public SubscribeController(EcommerceDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Subs(string id)
        {
            var subscribers = new Subscribe();
            if (string.IsNullOrWhiteSpace(id))
            {
                return Json(new
                {
                    error = true,
                    msg = "The email format entered is incorrect!",
                });
            }
            else
            {
                subscribers.Email = id;

                if (ModelState.IsValid)
                {

                    db.Subscribes.Add(subscribers);
                    db.SaveChanges();
                    return Json(new
                    {
                        error = false,
                        msg = "Thank you for subscribing!",
                    });
                }
                else
                {
                    return Json(new
                    {
                        error = true,
                        msg = "The email format entered is incorrect!",
                    });
                }
            }



        }


    }
}
