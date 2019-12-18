using System.ComponentModel.DataAnnotations;

namespace Backend.Models {
    public class Login {
        [Required]
        [StringLength (11)]
        public string Username { get; set; }

        [Required]
        [StringLength (11)]
        public string Password { get; set; }
    }
}