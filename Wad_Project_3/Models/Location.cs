using System.ComponentModel.DataAnnotations;

namespace Wad_Project_3.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Number { get; set; }//street number can be 32A for example

        public City City { get; set; }
    }
}
