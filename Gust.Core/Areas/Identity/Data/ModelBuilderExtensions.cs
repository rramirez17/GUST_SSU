using Gust.Core.Areas.Identity.Data.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Gust.Core.Areas.Identity.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Roles
            List<IdentityRole> roles = new()
            {
                new IdentityRole{ Name = "Administrador", NormalizedName = "ADMINISTRADOR".ToUpper()},
                new IdentityRole{ Name = "Tec", NormalizedName = "TEC".ToUpper()}
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);


            // Users
            List<GustCoreUser> users = new()
            {
                new GustCoreUser
                {
                    UserName = "luis.villalaz1@utp.ac.pa",
                    NormalizedUserName = "LUIS.VILLALAZ1@UTP.AC.PA".ToUpper(),
                    Email = "luis.villalaz1@utp.ac.pa",
                    NormalizedEmail = "LUIS.VILLALAZ1@UTP.AC.PA".ToUpper(),
                    EmailConfirmed = true
                }
            };

            var passwordHasher = new PasswordHasher<GustCoreUser>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Passgust22");

            modelBuilder.Entity<GustCoreUser>().HasData(users);

            // User - Roles
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>
                {
                    UserId = users[0].Id,
                    RoleId = roles.First(r => r.Name == "Administrador").Id
                },
                new IdentityUserRole<string>
                {
                    UserId = users[0].Id,
                    RoleId = roles.First(r => r.Name == "Tec").Id
                }
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            // Equipos
            List<Equipo> equipos = new()
            {
                new Equipo
                {
                    Id = 1,
                    CodigoBienesPatrimoniales = "E_PRUEBA_1",
                    Identificador = "EP1",
                    NombreEquipo = "Equipo Prueba 1",
                    Modelo = "Modelo1",
                    Activo = true
                },
                new Equipo
                {
                    Id = 2,
                    CodigoBienesPatrimoniales = "E_PRUEBA_2",
                    Identificador = "EP2",
                    NombreEquipo = "Equipo Prueba 2",
                    Modelo = "Modelo2",
                    Activo = true
                },
                new Equipo
                {
                    Id = 3,
                    CodigoBienesPatrimoniales = "E_PRUEBA_3",
                    Identificador = "EP3",
                    NombreEquipo = "Equipo Prueba 3",
                    Modelo = "Modelo3",
                    Activo = true
                }
            };

            modelBuilder.Entity<Equipo>().HasData(equipos);
        }
    }
}
