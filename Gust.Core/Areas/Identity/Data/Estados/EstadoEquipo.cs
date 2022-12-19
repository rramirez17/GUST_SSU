using System.ComponentModel.DataAnnotations;

namespace Gust.Core.Areas.Identity.Data.States
{
    public class EstadoEquipo
    {
        [Key]
        public short CodigoEstado { get; set; }
        public string Nombre { get; set; }
    }
}
