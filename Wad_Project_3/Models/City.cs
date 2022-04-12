using System.ComponentModel.DataAnnotations;

namespace Wad_Project_3.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string County { get; set; }
    }
}
