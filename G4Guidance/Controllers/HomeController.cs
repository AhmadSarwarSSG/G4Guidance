using G4Guidance;
using G4_Guidance.Models;
using G4_Guidance.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using G4Guidance.Models;
using G4Guidance.Models.Interface;

namespace G4_Guidance.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILogin_Repository logininfo;
        private readonly IblogInfo_Repository bInfo;
        public HomeController(ILogger<HomeController> logger, ILogin_Repository info, IblogInfo_Repository Bloginfo)
        {
            bInfo = Bloginfo;
            logininfo = info;
            _logger = logger;
        }

        public PartialViewResult UserData()
        {
            return PartialView("_MyPartial");
        }
        public IActionResult Index()
        {
            ViewBag.fblog = bInfo.featuredBlog();
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            if(HttpContext.Request.Cookies["userrole"]=="Admin")
            {
                return RedirectToAction("index", "AdminUniversity");
            }
            else
            {
                return View();
            }
        }
        public IActionResult FindUniversity()
        {
            return View();
        }
        public IActionResult Playlist()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
