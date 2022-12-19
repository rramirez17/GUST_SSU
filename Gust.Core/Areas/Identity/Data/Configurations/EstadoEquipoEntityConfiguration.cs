using Gust.Core.Areas.Identity.Data.States;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gust.Core.Areas.Identity.Data.Configurations
{
    public class EstadoEquipoEntityConfiguration : IEntityTypeConfiguration<EstadoEquipo>
    {
        public void Configure(EntityTypeBuilder<EstadoEquipo> builder)
        {
            builder.HasKey(i => i.CodigoEstado)
                .HasName("PK_EstadoEquipo_Id");

            builder.Property(u => u.CodigoEstado)
                .UseIdentityColumn();

            builder.Property(u => u.Nombre)
                .HasMaxLength(20);
        }
    }
}