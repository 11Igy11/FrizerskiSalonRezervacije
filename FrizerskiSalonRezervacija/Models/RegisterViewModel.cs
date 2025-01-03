using System.ComponentModel.DataAnnotations;

namespace FrizerskiSalonRezervacija.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Lozinke se ne podudaraju.")]
        public string ConfirmPassword { get; set; }
    }
}
