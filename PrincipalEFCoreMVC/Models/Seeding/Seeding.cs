using Microsoft.EntityFrameworkCore;

namespace PrincipalEFCoreMVC.Models.Seeding
{
    public static class Seeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var jan1 = new Holiday { Id = 1, Year = "2024", Date = new DateTime(2024, 01, 01) };
            var mar29 = new Holiday { Id = 2, Year = "2024", Date = new DateTime(2024, 03, 29) };
            var may1 = new Holiday { Id = 3, Year = "2024", Date = new DateTime(2024, 05, 01) };
            var may5 = new Holiday { Id = 4, Year = "2024", Date = new DateTime(2024, 05, 05) };

            modelBuilder.Entity<Holiday>().HasData(jan1, mar29, may1);
        }
    }
}
