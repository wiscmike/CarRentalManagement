using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole()
                    {
                        Id = "3620d7cf-b86a-4333-8848-d3698532d319",
                        Name = "User",
                        NormalizedName = "USER"
                    },
                    new IdentityRole()
                    {
                        Id = "4fe0b7ce-e739-42f2-9ef9-4443993b2179",
                        Name = "Administrator",
                        NormalizedName = "ADMINISTRATOR"
                    });

        }
    }
}
