using System.ComponentModel.DataAnnotations;

namespace Gust.Core.Areas.Identity.Data.Forms
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string CedulaPersona { get; set; }
        public string NombrePersona { get; set; }
        public string CategoriaPersona { get; set; }
    }
}
