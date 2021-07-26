using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>() // user
                {
                    RoleId = "3620d7cf-b86a-4333-8848-d3698532d319",
                    UserId = "7E32809A-FB04-41A6-8A0E-AD4D0F8E7FF8"
                },
                new IdentityUserRole<string>() // admin
                {
                    RoleId = "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                    UserId = "9BB159FA-1AE6-478B-A4F3-43BE5B450134"
                });
        }
    }
}
