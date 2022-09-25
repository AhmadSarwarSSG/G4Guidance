using Microsoft.AspNetCore.Mvc;
using G4Guidance.Models.Interface;
namespace G4Guidance.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        private readonly IblogInfo_Repository bInfo;
        public BlogController(ILogger<BlogController> logger, IblogInfo_Repository Bloginfo)
        {
            bInfo = Bloginfo;
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.blogs = bInfo.allBlog();
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            return View();
        }
    }
}
