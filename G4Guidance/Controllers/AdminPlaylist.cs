using Microsoft.AspNetCore.Mvc;
using G4Guidance.Models;
using G4Guidance.Models.Repository;
using G4_Guidance.Models.Interface;
using G4Guidance.Models.Interface;
namespace G4Guidance.Controllers
{

    public class AdminPlaylist : Controller
    {
        private readonly ILogger<AdminPlaylist> _logger;
        private readonly IPlaylistRepository Video;
        public AdminPlaylist(ILogger<AdminPlaylist> logger, IPlaylistRepository info)
        {
            Video = info;
            _logger = logger;
        }
        public IActionResult Index()
        {
            DataContainer.userifo = HttpContext.Request.Cookies["username"];
            ViewBag.list=Video.allVideos();
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            return View();
        }
        public IActionResult AddVideo()
        {
            DataContainer.userifo = HttpContext.Request.Cookies["username"];
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            return View();
        }
        [HttpPost]
        public IActionResult AddVideo(G4Guidance.Models.Playlist playlist)
        {
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            if (playlist.Name != null && playlist.link != null)
            {
                Video.insertData(playlist);
            }
            return RedirectToAction("index", "AdminPlaylist");
        }
        public IActionResult DeleteVideo(int id)
        {
            Video.DeleteVideos(id);
            return RedirectToAction("index", "AdminPlaylist");
        }
        public IActionResult EditVideo(int id)
        {
            DataContainer.userifo = HttpContext.Request.Cookies["username"];
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            ViewBag.userrole = HttpContext.Request.Cookies["userrole"];
            ViewBag.info = Video.getVideo(id)[0];
            return View();
        }
        [HttpPost]
        public IActionResult EditVideo(G4Guidance.Models.Playlist playlist)
        {
            Video.UpdateVideos(playlist);
            return RedirectToAction("index", "AdminPlaylist");
        }
    }
}
