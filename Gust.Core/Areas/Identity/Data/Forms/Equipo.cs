using Gust.Core.Areas.Identity.Data.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gust.Core.Areas.Identity.Data.Forms
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string? CodigoBienesPatrimoniales { get; set; }
        [MaxLength(30)]
        public string? Identificador { get; set; }
        [MaxLength(20)]
        public string? NombreEquipo { get; set; }
        [MaxLength(20)]
        public string? Modelo { get; set; }
        [MaxLength(10)]
        public string? VidaUtilEstimada { get; set; }
        public DateTime? FechaCompra { get; set; }
        public DateTime? FechaRegistro { get; set; }
        [MaxLength(30)]
        public string? Descripcion { get; set; }
        public int? LaboratorioId { get; set; }
        [ForeignKey("LaboratorioId")]
        public virtual Laboratorio Laboratorio { get; set; }
        public virtual ICollection<Tarea> Tareas { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Activo { get; set; }
    }
}
