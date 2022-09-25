using System.ComponentModel.DataAnnotations.Schema;
namespace G4_Guidance.Models
{

    public class EditingInfo
    {
        [Column(TypeName = "varchar(50)")]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? CreatedOn { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? ModifiedBy { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? ModifitedOn { get; set; }
    }
}
