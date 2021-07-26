using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
                    new Make()
                    {
                        Id = 1,
                        Name = "Honda",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Make()
                    {
                        Id = 2,
                        Name = "Subaru",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Make()
                    {
                        Id = 3,
                        Name = "Tesla",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Make()
                    {
                        Id = 4,
                        Name = "Ford",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    });
        }
    }
}
