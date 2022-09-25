using G4_Guidance.Models;
namespace G4Guidance.Models
{
    public class University:EditingInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string intro { get; set; }
        public string Type { get; set; }
        public int LastYearsMarks { get; set; }
        public string? pic { get; set; } = null;
    }
}
