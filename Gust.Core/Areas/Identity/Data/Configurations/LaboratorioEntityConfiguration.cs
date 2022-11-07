using Gust.Core.Areas.Identity.Data.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gust.Core.Areas.Identity.Data.Configurations
{
    public class LaboratorioEntityConfiguration : IEntityTypeConfiguration<Laboratorio>
    {
        public void Configure(EntityTypeBuilder<Laboratorio> builder)
        {
            builder.HasKey(i => i.Id)
                .HasName("PK_Laboratorio_Id");
            builder.HasIndex(i => i.Codigo)
                .IsUnique();

            builder.Property(u => u.Id)
                .UseIdentityColumn();

            builder.Property(u => u.Codigo)
                .HasMaxLength(15);
            builder.Property(u => u.CantidadSillas)
                .IsRequired(false);
            builder.Property(u => u.CantidadMesas)
                .IsRequired(false);
            builder.Property(u => u.CantidadComputadoras)
                .IsRequired(false);
            builder.Property(u => u.Activo)
                .HasDefaultValue(false);
        }
    }
}