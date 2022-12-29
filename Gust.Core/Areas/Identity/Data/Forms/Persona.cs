using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gust.Core.Areas.Identity.Data.Forms
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CedulaPersona { get; set; }
        public string NombrePersona { get; set; }
        public string CategoriaPersona { get; set; }
    }
}
