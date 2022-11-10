using Gust.Core.Areas.Identity.Data.Forms;
using Gust.Core.Areas.Identity.Data.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gust.Core.Areas.Identity.Data.Configurations
{
    public class EquipoEntityConfiguration : IEntityTypeConfiguration<Equipo>
    {
        public void Configure(EntityTypeBuilder<Equipo> builder)
        {
            builder.HasKey(i => i.Id)
                .HasName("PK_Equipo_Id");
            builder.HasIndex(i => i.CodigoBienesPatrimoniales)
                .IsUnique();
            builder.HasIndex(i => i.Identificador)
                .IsUnique();

            builder
                .HasOne(e => e.Laboratorio)
                .WithMany()
                .HasForeignKey("LaboratorioId")
                .HasConstraintName("FK_Equipo_LaboratorioId");
            builder
                .HasMany(e => e.Tareas)
                .WithMany(e => e.Equipos);

            builder.Property(u => u.Id)
                .UseIdentityColumn();

            builder.Property(u => u.CodigoBienesPatrimoniales)
                .HasMaxLength(20)
                .IsRequired(false);
            builder.Property(u => u.Identificador)
                .HasMaxLength(30)
                .IsRequired(false);
            builder.Property(u => u.NombreEquipo)
                .HasMaxLength(20)
                .IsRequired(false);
            builder.Property(u => u.Modelo)
                .HasMaxLength(20)
                .IsRequired(false);
            builder.Property(u => u.VidaUtilEstimada)
                .HasMaxLength(10)
                .IsRequired(false);
            builder.Property(u => u.FechaCompra)
                .IsRequired(false);
            builder.Property(u => u.FechaRegistro)
                .IsRequired(false);
            builder.Property(u => u.Descripcion)
                .HasMaxLength(30)
                .IsRequired(false);
            builder.Property(u => u.LaboratorioId)
                .IsRequired(false);
            builder.Property(u => u.Activo)
                .HasDefaultValue(false);
        }
    }
}