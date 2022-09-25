using G4Guidance.Models.Interface;
namespace G4Guidance.Models.Repository
{
    public class UniversityRepository:IUniveristyRepository
    {
        public void insertData(University uni)
        {
            var db = new G4GuidanceContext();
            db.uniInfos.Add(uni);
            db.SaveChanges();
        }
        public List<University> allunis()
        {
            var db = new G4GuidanceContext();
            List<University> unis = db.uniInfos.ToList();
            return unis;
        }
        public List<University> getuni(int id)
        {
            var db = new G4GuidanceContext();
            List<University> unis = db.uniInfos.Where(uni => uni.ID == id).ToList();
            return unis;
        }
        public List<University> getuni_type(string type)
        {
            var db = new G4GuidanceContext();
            List<University> unis = db.uniInfos.Where(uni => uni.Type == type).ToList();
            return unis;
        }
        public List<University> getuni_marks(int marks)
        {
            var db = new G4GuidanceContext();
            List<University> unis = db.uniInfos.Where(uni => uni.LastYearsMarks <= marks).ToList();
            return unis;
        }
        public List<University> getuni_type_marks(int marks, string type)
        {
            var db = new G4GuidanceContext();
            List<University> unis = db.uniInfos.Where(uni => uni.LastYearsMarks <= marks && uni.Type==type).ToList();
            return unis;
        }
        public void Deleteunis(int id)
        {
            var db = new G4GuidanceContext();
            db.uniInfos.Remove(getuni(id)[0]);
            db.SaveChanges();
        }
        public void Updateunis(University uni)
        {
            var db = new G4GuidanceContext();
            var unis = db.uniInfos.Where(uni1 => uni1.ID == uni.ID).SingleOrDefault();
            unis.Name = uni.Name;
            unis.intro = uni.intro;
            unis.LastYearsMarks = uni.LastYearsMarks;
            unis.Type = uni.Type;
            unis.pic = uni.pic;
            db.SaveChanges();
        }
    }
}
