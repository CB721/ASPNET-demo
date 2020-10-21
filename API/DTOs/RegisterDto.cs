using System.ComponentModel.DataAnnotations;

namespace ASPNETAngularDemo.API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Password cannot exceed 25 characters")]
        public string Password { get; set; }
    }
}