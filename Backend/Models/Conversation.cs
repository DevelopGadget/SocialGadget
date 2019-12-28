using System.Collections.Generic;

namespace Backend.Models {
    public class Conversation {
        public List<Message> Messages { get; set; }
        public List<User> Members { get; set; }
        
    }
}