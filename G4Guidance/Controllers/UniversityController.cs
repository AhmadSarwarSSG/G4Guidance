using Microsoft.AspNetCore.Mvc;
using G4Guidance.Models;
using G4_Guidance.Models;
using G4Guidance.Models.Interface;
using G4_Guidance.Models.Interface;
namespace G4Guidance.Controllers
{
    public class UniversityController : Controller
    {
        private readonly ILogger<UniversityController> _logger;
        private readonly IUniveristyRepository uniinfo;
        private readonly IWebHostEnvironment Environment;
        public UniversityController(ILogger<UniversityController> logger, IUniveristyRepository info, IWebHostEnvironment environment)
        {
            uniinfo = info;
            _logger = logger;
            Environment = environment;
        }
        public JsonResult getUniFromType(string uniData, string marksData)
        {
            List<University> unilist;
            if (marksData == null)
            {
                if (uniData == "All")
                {
                    unilist = uniinfo.allunis();
                }
                else
                {
                    unilist = uniinfo.getuni_type(uniData);
                }
            }
            else
            {
                if (uniData == "All")
                {
                    int marks = int.Parse(marksData);
                    unilist = uniinfo.getuni_marks(marks);
                }
                else
                {
                    int marks = int.Parse(marksData);
                    unilist = uniinfo.getuni_type_marks(marks,uniData);
                }
            }
            return Json(unilist);
        }
        public JsonResult getUniFromMarks(string marksData)
        {
            int marks = int.Parse(marksData);
            List<University> unilist = uniinfo.getuni_marks(marks);
            return Json(unilist);
        }
        public IActionResult Index()
        {
            ViewBag.uni = uniinfo.allunis();
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            return View();
        }
    }
}
