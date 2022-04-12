using Microsoft.EntityFrameworkCore;
using Wad_Project_3.Models;

namespace Wad_Project_3.Data
{
    public class Aplication: DbContext//uses Entity Framework Core
    {
        public Aplication(DbContextOptions<Aplication> options) : base(options) 
        {
        }
        // All database tables that have to be created
        public DbSet<User> Users { get; set; } // The table containing the user class will be called Users

        public DbSet<Message> Messages { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Parking_Spot> Parking_Spots { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Parking_Lot> Parking_Lots { get; set; }
    }
}
