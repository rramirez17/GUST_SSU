using Gust.Core.Areas.Identity.Data.States;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gust.Core.Areas.Identity.Data.Configurations
{
    public class EstadoTareaEntityConfiguration : IEntityTypeConfiguration<EstadoTarea>
    {
        public void Configure(EntityTypeBuilder<EstadoTarea> builder)
        {
            builder.HasKey(i => i.CodigoEstado)
                .HasName("PK_EstadoTarea_Id");

            builder.Property(u => u.CodigoEstado)
                .UseIdentityColumn();

            builder.Property(u => u.Nombre)
                .HasMaxLength(20);
        }
    }
}