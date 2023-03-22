using System.ComponentModel.DataAnnotations;

namespace backend_part.Models
{
    public class UserRegister
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage ="Please Enter at leaste 6 characters!")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required,Phone]
        public string PhoneNo { get; set; } = string.Empty;
    }
}
