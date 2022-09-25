using G4Guidance.Models.Interface;

namespace G4Guidance.Models.Repository
{
    public class blogInfo_Repository : IblogInfo_Repository
    {
        public void insertData(blogInfo blog)
        {
            var db = new G4GuidanceContext();
            db.blogInfos.Add(blog);
            db.SaveChanges();
        }

        public List<blogInfo> getblog(blogInfo info)
        {
            var db = new G4GuidanceContext();
            List<blogInfo> blogs = db.blogInfos.Where(blog => blog.Id == info.Id).ToList();
            return blogs;

        }

        public List<blogInfo> featuredBlog()
        {
            var db = new G4GuidanceContext();
            List<blogInfo> fblogs = db.blogInfos.Where(blog => blog.IsFeatured == true).ToList();
            return fblogs;
        }
        public List<blogInfo> allBlog()
        {
            var db = new G4GuidanceContext();
            List<blogInfo> blogs = db.blogInfos.ToList();
            return blogs;
        }
        public List<blogInfo> getblog(int id)
        {
            var db = new G4GuidanceContext();
            List<blogInfo> blogs = db.blogInfos.Where(video => video.Id == id).ToList();
            return blogs;
        }
        public void DeleteBlog(int id)
        {
            var db = new G4GuidanceContext();
            db.blogInfos.Remove(getblog(id)[0]);
            db.SaveChanges();
        }
        public void Updateblog(blogInfo blog)
        {
            var db = new G4GuidanceContext();
            var blogs = db.blogInfos.Where(blog1 => blog1.Id == blog.Id).SingleOrDefault();
            blogs.Title = blog.Title;
            blogs.Description = blog.Description;
            blogs.IsFeatured = blog.IsFeatured;
            blogs.ImgPath = blog.ImgPath;
            db.SaveChanges();
        }
    }
}
