using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(16, MinimumLength=8, ErrorMessage="Minimum length of password is 8 characters")]
        public string Password { get; set; }
    }
}