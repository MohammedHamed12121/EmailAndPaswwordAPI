using System.ComponentModel.DataAnnotations;

namespace VerifyEmailAndPassword1.Models
{
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MinLength(6)]
        public string? Password { get; set; }
    }
}
