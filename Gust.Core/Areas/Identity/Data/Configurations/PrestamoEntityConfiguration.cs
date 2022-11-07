using Gust.Core.Areas.Identity.Data.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gust.Core.Areas.Identity.Data.Configurations
{
    public class PrestamoEntityConfiguration : IEntityTypeConfiguration<Prestamo>
    {
        public void Configure(EntityTypeBuilder<Prestamo> builder)
        {
            builder.HasKey(i => i.Id)
                .HasName("PK_Prestamo_Id");

            builder
                .HasOne(e => e.PersonaEntrega)
                .WithMany()
                .HasForeignKey("PersonaEntregaId")
                .HasConstraintName("FK_Prestamo_PersonaEntregaId");

            builder
                .HasOne(e => e.PersonaRecibe)
                .WithMany()
                .HasForeignKey("PersonaRecibeId")
                .HasConstraintName("FK_Prestamo_PersonaRecibeId");

            builder.Property(u => u.Id)
                .UseIdentityColumn();

            builder.Property(u => u.NombrePersona)
                .HasMaxLength(15);
            builder.Property(u => u.CedulaPersona)
                .HasMaxLength(25);
            builder.Property(u => u.Duracion)
                .HasMaxLength(20)
                .IsRequired(false);
            builder.Property(u => u.Descripcion)
                .HasMaxLength(30)
                .IsRequired(false);
            builder.Property(u => u.FechaDevolucion)
                .IsRequired(false);
            builder.Property(u => u.PersonaRecibeId)
                .IsRequired(false);
        }
    }
}