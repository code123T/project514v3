using EcommerceWebUILab.Models.DataContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EcommerceWebUILab.Controllers
{
    public class BasketController : Controller
    {
        readonly EcommerceDbContext db;
        public BasketController(EcommerceDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            string cookieValueFromReq = Request.Cookies["ecommercecookie"];
            var value = Convert.ToInt32(cookieValueFromReq);
            ViewData["User"] = value;


            var count = db.Baskets.Where(p => p.UserId == value).Count();




            ViewBag.Count = count;
            return View();
        }
    }
}
