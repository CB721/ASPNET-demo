using System.ComponentModel.DataAnnotations;

namespace ASPNETAngularDemo.API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 25 characters")]
        public string Password { get; set; }
    }
}