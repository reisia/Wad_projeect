using System.ComponentModel.DataAnnotations;

namespace Wad_Project_3.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
    }
}
