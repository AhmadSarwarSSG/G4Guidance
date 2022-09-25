namespace G4Guidance.Models.Interface
{
    public interface IUniveristyRepository
    {
        public void insertData(University uni);
        public List<University> allunis();
        public List<University> getuni(int id);
        public void Deleteunis(int id);
        public void Updateunis(University uni);
        public List<University> getuni_type(string type);
        public List<University> getuni_marks(int marks);
        public List<University> getuni_type_marks(int marks, string type);
    }
}
