using Gust.Core.Areas.Identity.Data;
using Gust.Core.Areas.Identity.Data.Configurations;
using Gust.Core.Areas.Identity.Data.Forms;
using Gust.Core.Areas.Identity.Data.States;
using Gust.Core.Areas.Identity.Data.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gust.Core.Data;

public class GustCoreContext : IdentityDbContext<GustCoreUser>
{
    public virtual DbSet<Equipo> Equipo { get; set; }
    public virtual DbSet<Laboratorio> Laboratorio { get; set; }
    public virtual DbSet<Prestamo> Prestamo { get; set; }
    public virtual DbSet<Reserva> Reserva { get; set; }
    public virtual DbSet<Tarea> Tarea { get; set; }

    public virtual DbSet<EstadoTarea> EstadoTarea { get; set; }

    public GustCoreContext(DbContextOptions<GustCoreContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new GustCoreUserEntityConfiguration());
        builder.ApplyConfiguration(new LaboratorioEntityConfiguration());
        builder.ApplyConfiguration(new EquipoEntityConfiguration());
        builder.ApplyConfiguration(new PrestamoEntityConfiguration());
        builder.ApplyConfiguration(new ReservaEntityConfiguration());

        builder.Seed();
    }
}
