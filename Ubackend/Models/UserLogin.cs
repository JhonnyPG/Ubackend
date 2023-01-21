using System.ComponentModel.DataAnnotations;

namespace Ubackend.Models
{
    public class UserLogin
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
