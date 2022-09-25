using G4_Guidance;
using G4Guidance.Models;
namespace G4_Guidance.Models.Interface
{
    public interface ILogin_Repository
    {
        public void insertData(LoginInfo user);
        public List<LoginInfo> getUser(LoginInfo info);
        public List<LoginInfo> getUser(string username);
    }
}
