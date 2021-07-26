using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                    new ApplicationUser()
                    {
                        Id = "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8",
                        Email = "user@localhost.com",
                        NormalizedEmail = "USER@LOCALHOST.COM",
                        FirstName = "System",
                        LastName = "User",
                        UserName = "user@localhost.com",
                        NormalizedUserName = "USER@LOCALHOST.COM",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1")
                    },
                    new ApplicationUser()
                    {
                        Id = "9BB159FA-1AE6-478B-A4F3-43BE5B450134",
                        Email = "admin@localhost.com",
                        NormalizedEmail = "ADMIN@LOCALHOST.COM",
                        FirstName = "System",
                        LastName = "Admin",
                        UserName = "admin@localhost.com",
                        NormalizedUserName = "ADMIN@LOCALHOST.COM",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1")
                    });

        }
    }
}
