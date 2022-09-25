using Microsoft.AspNetCore.Mvc;
using G4Guidance.Models;
using G4_Guidance.Models.Interface;
using G4Guidance.Models.Interface;
namespace G4Guidance.Controllers
{
    public class Playlist : Controller
    {
        private readonly ILogger<Playlist> _logger;
        private readonly IPlaylistRepository Video;
        public Playlist(ILogger<Playlist> logger, IPlaylistRepository info)
        {
            Video = info;
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.list = Video.allVideos();
            ViewBag.userinfo = HttpContext.Request.Cookies["username"];
            ViewBag.img = HttpContext.Request.Cookies["userimg"];
            return View();
        }
    }
}
