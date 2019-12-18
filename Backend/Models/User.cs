using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models {
    public class User {
        [Required]
        [Key]
        [StringLength (11)]
        public string Username { get; set; }

        [Required]
        [StringLength (11)]
        public string Password { get; set; }

        [Required]
        [StringLength (50)]
        public string Name { get; set; }

        [Required]
        [StringLength (150)]
        [DataType(DataType.ImageUrl)]
        public string UrlImage { get; set; }

        [DataType (DataType.Date)]
        public DateTime CreateAt { get { return CreateAt; } set { CreateAt = DateTime.Now; } }
    }
}