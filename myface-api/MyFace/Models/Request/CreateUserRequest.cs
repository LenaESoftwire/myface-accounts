using System.ComponentModel.DataAnnotations;

namespace MyFace.Models.Request
{
    public class CreateUserRequest
    {
        [Required]
        [StringLength(70)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(70)]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [StringLength(70)]
        public string Username { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 8, ErrorMessage = "Length must be between 8 and 70 symbols")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$", ErrorMessage = "Password must be between 8 and 70 characters and contain one uppercase letter, one lowercase letter, one digit.")]
        public string Password { get; set; }

        public string ProfileImageUrl { get; set; }
        
        public string CoverImageUrl { get; set; }
    }
}