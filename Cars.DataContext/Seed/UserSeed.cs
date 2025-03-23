using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Cars.Model;
using Cars.Model.Identity;

namespace Cars.DataContext.Seed
{
    public static class UserSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHasher<User>();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Client", NormalizedName = "CLIENT" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = "1", UserName = "admin@example.com", Email = "admin@example.com", NormalizedUserName = "ADMIN@EXAMPLE.COM", NormalizedEmail = "ADMIN@EXAMPLE.COM", EntrepriseId = null, PasswordHash = passwordHasher.HashPassword(null, "AdminPass123") },
                    new User { Id = "2", UserName = "client1@example.com", Email = "client1@example.com", NormalizedUserName = "CLIENT1@EXAMPLE.COM", NormalizedEmail = "CLIENT1@EXAMPLE.COM", EntrepriseId = 1, PasswordHash = passwordHasher.HashPassword(null, "ClientPass123") },
                new User { Id = "3", UserName = "client2@example.com", Email = "client2@example.com", NormalizedUserName = "CLIENT2@EXAMPLE.COM", NormalizedEmail = "CLIENT2@EXAMPLE.COM", EntrepriseId = 2, PasswordHash = passwordHasher.HashPassword(null, "ClientPass123") },
                new User { Id = "4", UserName = "client3@example.com", Email = "client3@example.com", NormalizedUserName = "CLIENT3@EXAMPLE.COM", NormalizedEmail = "CLIENT3@EXAMPLE.COM", EntrepriseId = 3, PasswordHash = passwordHasher.HashPassword(null, "ClientPass123") },
                new User { Id = "5", UserName = "client4@example.com", Email = "client4@example.com", NormalizedUserName = "CLIENT4@EXAMPLE.COM", NormalizedEmail = "CLIENT4@EXAMPLE.COM", EntrepriseId = 4, PasswordHash = passwordHasher.HashPassword(null, "ClientPass123") }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "1", RoleId = "1" }, // Admin
                new IdentityUserRole<string> { UserId = "2", RoleId = "2" }, // Client 1
                new IdentityUserRole<string> { UserId = "3", RoleId = "2" }, // Client 2
                new IdentityUserRole<string> { UserId = "4", RoleId = "2" }, // Client 3
                new IdentityUserRole<string> { UserId = "5", RoleId = "2" }  // Client 4
            );
        }
    }
}
