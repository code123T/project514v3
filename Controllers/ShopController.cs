using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebUILab.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index(int? gender, int? category, int? campaign)
        {
            ViewData["Gender"] = gender;
            ViewData["Category"] = category;
            ViewData["Campaign"] = campaign;
            return View();
        }
    }
}
