namespace G4Guidance.Models.Interface
{
    public interface IPlaylistRepository
    {
        public void insertData(Playlist video);
        public List<Playlist> allVideos();
        public void DeleteVideos(int id);
        public List<Playlist> getVideo(int id);
        public void UpdateVideos(Playlist video);
    }
}
