using System.ComponentModel.DataAnnotations.Schema;

namespace Gust.Core.Areas.Identity.Data.Forms
{
    public class Prestamo
    {
        public int Id { get; set; }
        public string NombrePersona { get; set; }
        public string CedulaPersona { get; set; }
        public string? Duracion { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public int EquipoId { get; set; }
        [ForeignKey("EquipoId")]
        public virtual Equipo Equipo { get; set; }
        public string PersonaEntregaId { get; set; }
        [ForeignKey("PersonaEntregaId")]
        public virtual GustCoreUser PersonaEntrega { get; set; }
        public string? PersonaRecibeId { get; set; }
        [ForeignKey("PersonaRecibeId")]
        public virtual GustCoreUser PersonaRecibe { get; set; }
    }
}
