using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        //[StringLength(60, MinimumLength=3)]
        public string UserName { get; set; }

        [Required]
        //[StringLength(16,MinimumLength=5)]
        public string Password { get; set; }
    }
}