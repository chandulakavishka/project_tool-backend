using System.ComponentModel.DataAnnotations;

namespace backend_part.MODELS
{
    public class User
    {
        [Key]
        public int? UId { get; set; }
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(150)]
        public string LastName { get; set; } = string.Empty;
        [MaxLength(150)]
        public string Email { get; set; } = string.Empty;
        [MaxLength(150)]
        public string City { get; set; } = string.Empty;
        [MaxLength(300)]
        public string Description { get; set; } = string.Empty;

        public string PhoneNo { get; set; } = string.Empty;

        public UserRole Role { get; set; } 


    }
}
