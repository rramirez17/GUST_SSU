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
                }
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
