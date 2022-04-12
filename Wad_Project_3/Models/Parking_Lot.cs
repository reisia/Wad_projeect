using System.ComponentModel.DataAnnotations;

namespace Wad_Project_3.Models
{
    public class Parking_Lot
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Capacity { get; set; }

        public Location Location { get; set; }
    }
}
