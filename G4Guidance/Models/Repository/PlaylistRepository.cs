using G4Guidance.Models.Interface;
namespace G4Guidance.Models.Repository
{
    public class PlaylistRepository:IPlaylistRepository
    {
        public void insertData(Playlist video)
        {
            var db = new G4GuidanceContext();
            db.playlistInfos.Add(video);
            db.SaveChanges();
        }
        public List<Playlist> allVideos()
        {
            var db = new G4GuidanceContext();
            List<Playlist> videos = db.playlistInfos.ToList();
            return videos;
        }
        public List<Playlist> getVideo(int id)
        {
            var db = new G4GuidanceContext();
            List<Playlist> videos = db.playlistInfos.Where(video => video.ID == id).ToList();
            return videos;
        }
        public void DeleteVideos(int id)
        {
            var db = new G4GuidanceContext();
            db.playlistInfos.Remove(getVideo(id)[0]);
            db.SaveChanges();
        }
        public void UpdateVideos(Playlist video)
        {
            var db = new G4GuidanceContext();
            var videos = db.playlistInfos.Where(video1 => video1.ID == video.ID).SingleOrDefault();
            videos.Name = video.Name;
            videos.link = video.link;
            db.SaveChanges();
        }
    }
}
