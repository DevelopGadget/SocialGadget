using System.ComponentModel.DataAnnotations;

namespace Backend.Models {
    public class Message {

        [Required]
        public string MessageText { get; set; }

        [Required]
        public User ReciverUser { get; set; }
    }
}