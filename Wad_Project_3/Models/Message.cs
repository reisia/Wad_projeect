using System.ComponentModel.DataAnnotations;

namespace Wad_Project_3.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Message_Text { get; set; }
        [Required]
        public string Message_Subject { get; set; }
        public User User { get; set; }
    }
}
