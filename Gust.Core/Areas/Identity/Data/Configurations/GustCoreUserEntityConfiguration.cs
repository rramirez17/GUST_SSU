using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gust.Core.Areas.Identity.Data.Configurations
{
    public class GustCoreUserEntityConfiguration : IEntityTypeConfiguration<GustCoreUser>
    {
        public void Configure(EntityTypeBuilder<GustCoreUser> builder)
        {
            builder.HasIndex(i => i.Cedula)
                .IsUnique();

            builder.Property(u => u.Cedula)
                .HasMaxLength(12)
                .IsRequired(false);

            builder.Property(u => u.Nombre)
                .HasMaxLength(25)
                .IsRequired(false);

            builder.Property(u => u.Posicion)
                .HasMaxLength(15)
                .IsRequired(false);
        }
    }
}