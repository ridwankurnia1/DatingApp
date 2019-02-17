using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dto
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Password length must between 5 and 10")]
        public string Password { get; set; }
    }
}