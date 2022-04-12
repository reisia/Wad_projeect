using System.ComponentModel.DataAnnotations;

namespace Wad_Project_3.Models
{
    public class Parking_Spot
    {
        [Key]
        public int Id { get; set; }
        public Boolean Status { get; set; }
        public Message Message { get; set; }
    }
}
