﻿using Gust.Core.Areas.Identity.Data.Forms;
using Gust.Core.Areas.Identity.Data.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gust.Core.Areas.Identity.Data.Configurations
{
    public class TareaEntityConfiguration : IEntityTypeConfiguration<Tarea>
    {
        public void Configure(EntityTypeBuilder<Tarea> builder)
        {
            builder.HasKey(i => i.Id)
                .HasName("PK_Tarea_Id");

            builder
                .HasOne(e => e.PersonaEncargada)
                .WithMany()
                .HasForeignKey("PersonaEncargadaId")
                .HasConstraintName("FK_Tarea_PersonaEncargadaId");

            builder.Property(u => u.Id)
                .UseIdentityColumn();

            builder.Property(u => u.Nombre)
                .HasMaxLength(20);
            builder.Property(u => u.Especificacion)
                .HasMaxLength(35)
                .IsRequired(false);
            builder.Property(u => u.FechaAsignacion)
                .HasMaxLength(20)
                .IsRequired(false);
            builder.Property(u => u.FechaFinalizacion)
                .IsRequired(false);
            builder.Property(u => u.PersonaEncargadaId)
                .IsRequired(false);
        }
    }
}