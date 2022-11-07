using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Gust.Core.Areas.Identity.Data;

// Add profile data for application users by adding properties to the GustCoreUser class
public class GustCoreUser : IdentityUser
{
    [MaxLength(12)]
    public string? Cedula { get; set; }
    [MaxLength(25)]
    public string? Nombre { get; set; }
    [MaxLength(15)]
    public string? Posicion { get; set; }
}

