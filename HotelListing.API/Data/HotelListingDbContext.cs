using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Croatia",
                    ShortName = "CRO"
                },
                new Country
                {
                    Id = 3,
                    Name = "Spain",
                    ShortName = "ES"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Miramaris",
                    Address = "Vodice",
                    CountryId = 2,
                    Rating = 4,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Jaimspa",
                    Address = "George Town",
                    CountryId = 1,
                    Rating = 4,
                } 
                );
        }
    }
}
