using G4_Guidance.Models;
namespace G4Guidance.Models
{
    public class blogInfo:EditingInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        public bool IsFeatured { get; set; }
    }
}
