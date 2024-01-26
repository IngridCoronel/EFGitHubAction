using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PrincipalEFCoreMVC.Models.Configurations
{
    public class FormConfig : IEntityTypeConfiguration<Form>
    {
        public void Configure(EntityTypeBuilder<Form> builder)
        {
            builder.Property(prop => prop.IdSf)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(prop => prop.Status)
                .HasMaxLength(2)
                .IsRequired();

            builder.Property(prop => prop.sentSf)
                .HasDefaultValue(false);

            builder.Property(prop => prop.reasenRejection)
                .HasMaxLength(5);
        }
    }
}
