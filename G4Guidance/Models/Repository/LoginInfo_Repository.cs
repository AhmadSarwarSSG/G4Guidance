using G4_Guidance.Models.Interface;

namespace G4Guidance.Models.Repository
{
    public class LoginInfo_Repository : ILogin_Repository
    {
        public void insertData(LoginInfo user)
        {
            var db = new G4GuidanceContext();
            db.LoginInfos.Add(user);
            db.SaveChanges();
        }
        public List<LoginInfo> getUser(LoginInfo info)
        {
            var db = new G4GuidanceContext();
            List<LoginInfo> users = db.LoginInfos.Where(user => user.Username == info.Username).ToList();
            return users;

        }
        public List<LoginInfo> getUser(string username)
        {
            var db = new G4GuidanceContext();
            List<LoginInfo> users = db.LoginInfos.Where(user => user.Username == username).ToList();
            return users;

        }
    }
}
