using Gust.Core.Areas.Identity.Data.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gust.Core.Areas.Identity.Data.Tasks
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string? Nombre { get; set; }
        [MaxLength(550)]
        public string? Especificacion { get; set; }
        public DateTime? FechaAsignacion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }

        public string EstadoTarea { get; set; }

        public string PersonaEncargadaId { get; set; }

        public virtual GustCoreUser PersonaEncargada { get; set; }
        
    }
}
