using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gust.Core.Areas.Identity.Data.Forms
{
    public class Prestamo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        public string UsuarioEntregaId { get; set; }

        [ForeignKey("UsuarioEntregaId")]
        public virtual GustCoreUser UsuarioEntrega { get; set; }

        public string? UsuarioRecibeId { get; set; }

        [ForeignKey("UsuarioRecibeId")]
        public virtual GustCoreUser UsuarioRecibe { get; set; }
    }
}
