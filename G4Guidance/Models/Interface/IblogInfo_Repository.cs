namespace G4Guidance.Models.Interface
{
    public interface IblogInfo_Repository
    {
        public void insertData(blogInfo blog);
        public List<blogInfo> getblog(blogInfo info);
        public List<blogInfo> featuredBlog();
        public List<blogInfo> allBlog();
        public List<blogInfo> getblog(int id);
        public void DeleteBlog(int id);
        public void Updateblog(blogInfo blog);
    }
}
