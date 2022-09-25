using Microsoft.AspNetCore.Mvc;

namespace G4Guidance.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {

            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole= HttpContext.Request.Cookies["userrole"];
            return View();
        }
    }
}
