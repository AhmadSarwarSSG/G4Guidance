using Microsoft.AspNetCore.Mvc;
using G4Guidance.Models;
using G4Guidance.Models.Repository;
using G4_Guidance.Models;
using G4Guidance.Models.Interface;
using G4_Guidance.Models.Interface;
namespace G4Guidance.Controllers
{
    public class AdminUniversity : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IUniveristyRepository uniinfo;
        private readonly IWebHostEnvironment Environment;
        public AdminUniversity(ILogger<AccountController> logger, IUniveristyRepository info, IWebHostEnvironment environment)
        {
            uniinfo = info;
            _logger = logger;
            Environment = environment;
        }
        public IActionResult Index()
        {
            DataContainer.userifo = HttpContext.Request.Cookies["username"];
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            ViewBag.list = uniinfo.allunis();
            return View();
        }
        public IActionResult AddUni()
        {
            DataContainer.userifo = HttpContext.Request.Cookies["username"];
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            return View();
        }
        [HttpPost]
        public IActionResult AddUni(University uni, List<IFormFile> postedFiles)
        {
            var finalPath = "";
            string wwwPath = this.Environment.WebRootPath;
            string path = Path.Combine(wwwPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            foreach (var file in postedFiles)
            {

                var fileName = Path.GetFileName(file.FileName);
                var pathWithFileName = Path.Combine(path, fileName);
                finalPath = pathWithFileName;
                using (FileStream stream = new FileStream(pathWithFileName, FileMode.Create))
                {
                    file.CopyTo(stream);
                    ViewBag.Message = "file uploaded successfully";
                }
            }
            string path2 = finalPath.Replace("\\", "/");
            path2 = path2.Remove(0, 61);
            uni.pic = path2;
            uniinfo.insertData(uni);
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            return RedirectToAction("index", "AdminUniversity");
        }
        public IActionResult DeleteUni(int id)
        {
            uniinfo.Deleteunis(id);
            return RedirectToAction("index", "AdminUniversity");
        }
        public IActionResult EditUni(int id)
        {
            DataContainer.userifo = HttpContext.Request.Cookies["username"];
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            ViewBag.info = uniinfo.getuni(id)[0];
            return View();
        }
        [HttpPost]
        public IActionResult EditUni(University uni, List<IFormFile> postedFiles)
        {
            if (postedFiles.Count != 0)
            {
                var finalPath = "";
                string wwwPath = this.Environment.WebRootPath;
                string path = Path.Combine(wwwPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                foreach (var file in postedFiles)
                {

                    var fileName = Path.GetFileName(file.FileName);
                    var pathWithFileName = Path.Combine(path, fileName);
                    finalPath = pathWithFileName;
                    using (FileStream stream = new FileStream(pathWithFileName, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        ViewBag.Message = "file uploaded successfully";
                    }
                }
                string path2 = finalPath.Replace("\\", "/");
                path2 = path2.Remove(0, 61);
                uni.pic = path2;
            }
            else
            {
                uni.pic = uniinfo.getuni(uni.ID)[0].pic;
            }
            uniinfo.Updateunis(uni);
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            return RedirectToAction("index", "AdminUniversity");
        }
    }
}
