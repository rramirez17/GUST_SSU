using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gust.Core.Areas.Identity.Data.Forms
{
    public class Laboratorio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public int? CantidadSillas { get; set; }
        public int? CantidadMesas { get; set; }
        public int? CantidadComputadoras { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Activo { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
