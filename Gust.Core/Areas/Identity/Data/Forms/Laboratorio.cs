using Microsoft.Build.Framework;
using System.ComponentModel;

namespace Gust.Core.Areas.Identity.Data.Forms
{
    public class Laboratorio
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public int? CantidadSillas { get; set; }
        public int? CantidadMesas { get; set; }
        public int? CantidadComputadoras { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Activo { get; set; }
    }
}
