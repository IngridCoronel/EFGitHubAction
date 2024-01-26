using Microsoft.EntityFrameworkCore;
using PrincipalEFCoreMVC.Models;
using PrincipalEFCoreMVC.Models.Seeding;
using System.Reflection;

namespace PrincipalEFCoreMVC
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //siempre que se agreue un campo DatTime, se va a mapear a date
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //Toma las cases que heredan de IEntityTypeConfiguration (Todo lo que está en la carpeta Configurations)

            Seeding.Seed(modelBuilder);
        }



        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Form> Forms { get; set; }
    }
}
