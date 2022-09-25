using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using G4_Guidance.Models;
namespace G4Guidance.Models
{
    public partial class LoginInfo:EditingInfo
    {
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        public string? ProfileImg { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
