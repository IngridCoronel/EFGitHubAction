using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PrincipalEFCoreMVC.Models.Configurations
{
    public class HolidayConfig : IEntityTypeConfiguration<Holiday>
    {
        public void Configure(EntityTypeBuilder<Holiday> builder)
        {
            builder.Property(prop => prop.Year)
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(prop => prop.Date)
                .IsRequired();
        }
    }
}
