using System.ComponentModel.DataAnnotations;

namespace Wad_Project_3.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Second_Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }

        public Boolean Gender { get; set; }
        [Required]
        private string Password { get; set; }
    }
}
