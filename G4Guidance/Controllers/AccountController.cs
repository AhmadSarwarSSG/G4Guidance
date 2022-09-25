//using Microsoft.AspNetCore.Mvc;
//using G4Guidance.Models;
//using G4_Guidance.Models.Interface;
//using System.Diagnostics;

//namespace G4Guidance.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly ILogger<AccountController> _logger;
//        private readonly ILogin_Repository logininfo;
//        private readonly IWebHostEnvironment Environment;
//        public AccountController(ILogger<AccountController> logger, ILogin_Repository info, IWebHostEnvironment environment)
//        {
//            logininfo = info;
//            _logger = logger;
//            Environment = environment;
//        }
//        public IActionResult SignUp(LoginInfo su, List<IFormFile> postedFiles)
//        {

//            var finalPath="";
//            string wwwPath = this.Environment.WebRootPath;
//            string path = Path.Combine(wwwPath, "Uploads");
//            if (!Directory.Exists(path))
//            {
//                Directory.CreateDirectory(path);
//            }

//            foreach (var file in postedFiles)
//            {

//                var fileName = Path.GetFileName(file.FileName);
//                var pathWithFileName = Path.Combine(path, fileName);
//                finalPath = pathWithFileName;
//                using (FileStream stream = new FileStream(pathWithFileName, FileMode.Create))
//                {
//                    file.CopyTo(stream);
//                    ViewBag.Message = "file uploaded successfully";
//                }
//            }
//            var context = new G4GuidanceContext();
//            LoginInfo info = new LoginInfo();
//            if (su.Username != null && su.Password != null && su.Email != null)
//            {
//                if (ModelState.IsValid)
//                {
//                    info.Username = su.Username;
//                    info.Email = su.Email;
//                    info.Password = su.Password;
//                    info.ProfileImg = finalPath;
//                    context.LoginInfos.Add(info);
//                    context.SaveChanges();
//                    return RedirectToAction("Index", "Home");
//                }
//                return View();
//            }
//            else
//            {
//                return View();
//            }
//        }
//        public JsonResult CheckUsername(string userData)
//        {
//            List<LoginInfo> searchData = logininfo.getUser(userData);
//            if( searchData.Count > 0)
//            {
//                return Json(1);
//            }
//            else
//            {
//                return Json(0);
//            }
//        }
//        public JsonResult CheckPassword(string userData, string password)
//        {
//            List<LoginInfo> searchData = logininfo.getUser(userData);
//            if (searchData[0].Password == password)
//            {
//                return Json(1);
//            }
//            else
//            {
//                return Json(0);
//            }
//        }
//        public IActionResult Login(LoginInfo user)
//        {
//            var context = new G4GuidanceContext();
//            if (user.Username != null && user.Password != null)
//            {
//                if (logininfo.getUser(user).Count > 0)
//                {
//                    if (logininfo.getUser(user)[0].Password == user.Password)
//                    {
//                        CookieOptions options = new CookieOptions();
//                        options.Expires= DateTime.Now.AddDays(1);
//                        HttpContext.Response.Cookies.Append("username", user.Username, options);
//                        string path= logininfo.getUser(user)[0].ProfileImg.Replace("\\","/");
//                        path=path.Remove(0, 61);
//                        HttpContext.Response.Cookies.Append("userimg", path, options);
//                        ViewBag.userinfo = user.Username;
//                        return RedirectToAction("index", "Home");
//                    }
//                    else
//                    {
//                        ViewBag.Fail = "Username or Password Incorrect";
//                        return View();
//                    }
//                }
//                else
//                {
//                    ViewBag.Fail = "Username or Password Incorrect";
//                    return View();
//                }
//            }
//            else
//            {
//                return View();
//            }
//        }
//        public IActionResult signout()
//        {
//            HttpContext.Response.Cookies.Delete("username");
//            HttpContext.Response.Cookies.Delete("userimg");
//            return RedirectToAction("login", "account");

//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using G4Guidance.Models;
using G4Guidance.Models.Repository;
using G4_Guidance.Models.Interface;
using System.Diagnostics;

namespace G4Guidance.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly ILogin_Repository logininfo;
        private readonly IWebHostEnvironment Environment;
        public AccountController(ILogger<AccountController> logger, ILogin_Repository info, IWebHostEnvironment environment)
        {
            logininfo = info;
            _logger = logger;
            Environment = environment;
        }
        public IActionResult SignUp(LoginInfo su, List<IFormFile> postedFiles)
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
            var context = new G4GuidanceContext();
            LoginInfo info = new LoginInfo();
            if (su.Username != null && su.Password != null && su.Email != null)
            {
                if (ModelState.IsValid)
                {
                    info.Username = su.Username;
                    info.Email = su.Email;
                    info.Password = su.Password;
                    info.ProfileImg = finalPath;
                    context.LoginInfos.Add(info);
                    context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            else
            {
                return View();
            }
        }
        public JsonResult CheckUsername(string userData)
        {
            List<LoginInfo> searchData = logininfo.getUser(userData);
            if(searchData.Count>0)
            {
                return Json(searchData[0]);
            }
            else
            {
                return Json(0);
            }
        }
        public JsonResult CheckPassword(string userData, string password)
        {
            List<LoginInfo> searchData = logininfo.getUser(userData);
            if (searchData[0].Password == password)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }
        }
        public IActionResult Login(LoginInfo user)
        {
            var context = new G4GuidanceContext();
            if (user.Username != null && user.Password != null)
            {
                if (logininfo.getUser(user).Count > 0)
                {
                    if (logininfo.getUser(user)[0].Password == user.Password)
                    {
                        LoginInfo temp=logininfo.getUser(user.Username)[0];
                        DataContainer.userifo = temp.Username;
                        CookieOptions options = new CookieOptions();
                        options.Expires = DateTime.Now.AddDays(1);
                        HttpContext.Response.Cookies.Append("username", user.Username, options);
                        string path = logininfo.getUser(user)[0].ProfileImg.Replace("\\", "/");
                        path = path.Remove(0, 61);
                        HttpContext.Response.Cookies.Append("userimg", path, options);
                        HttpContext.Response.Cookies.Append("userrole", temp.Role, options);
                        ViewBag.userinfo = user.Username;
                        ViewBag.userrole=temp.Role;
                        if(temp.Role=="User")
                        {
                            return RedirectToAction("index", "Home");
                        }
                        else
                        {
                            return RedirectToAction("Index", "AdminUniversity");
                        }
                    }
                    else
                    {
                        ViewBag.Fail = "Username or Password Incorrect";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Fail = "Username or Password Incorrect";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public IActionResult signout()
        {
            HttpContext.Response.Cookies.Delete("username");
            HttpContext.Response.Cookies.Delete("userimg");
            return RedirectToAction("login", "account");

        }
    }
}

