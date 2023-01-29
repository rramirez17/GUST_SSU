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
                new IdentityRole{ Name = "Tecnico", NormalizedName = "TEC".ToUpper()}
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);


            // Users
            List<GustCoreUser> users = new()
            {
                new GustCoreUser
                {
                    UserName = "omar.carvajal@utp.ac.pa",
                    NormalizedUserName = "OMAR.CARVAJAL@UTP.AC.PA".ToUpper(),
                    Email = "omar.carvajal@utp.ac.pa",
                    NormalizedEmail = "OMAR.CARVAJAL@UTP.AC.PA".ToUpper(),
                    EmailConfirmed = true
                }
            };

            var passwordHasher = new PasswordHasher<GustCoreUser>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "GUST2023@");

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
                    RoleId = roles.First(r => r.Name == "Tecnico").Id
                }
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            // Laboratorios
            List<Laboratorio> laboratorios = new()
            {
                new Laboratorio{
                    Id = 1,
                    Codigo = "3-401",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{
                    Id = 2,
                    Codigo = "3-402",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 3,
                    Codigo = "3-403",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 4,
                    Codigo = "3-404",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 5,
                    Codigo = "3-405",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 6,
                    Codigo = "3-406",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 7,
                    Codigo = "3-407",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 8,
                    Codigo = "3-408",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 9,
                    Codigo = "3-409",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 10,
                    Codigo = "3-410",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 11,
                    Codigo = "3-BG01",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 12,
                    Codigo = "3-411",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 13,
                    Codigo = "3-412",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 14,
                    Codigo = "3-413",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 15,
                    Codigo = "3-414",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 16,
                    Codigo = "3-415",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 17,
                    Codigo = "3-416",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 18,
                    Codigo = "3-417",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 19,
                    Codigo = "3-418",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 20,
                    Codigo = "3-419",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 21,
                    Codigo = "3-420",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 22,
                    Codigo = "3-421",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                },
                new Laboratorio{Id = 23,
                    Codigo = "3-422",
                    Activo = true,
                    CantidadComputadoras = 20,
                    CantidadMesas = 20,
                    CantidadSillas = 20

                }
            };

            modelBuilder.Entity<Laboratorio>().HasData(laboratorios);

        }
    }
}
