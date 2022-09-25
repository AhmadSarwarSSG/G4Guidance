using Microsoft.AspNetCore.Mvc;

namespace G4Guidance.Controllers
{
    public class Aboutus : Controller
    {
        public IActionResult Index()
        {
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            return View();
        }
    }
}
