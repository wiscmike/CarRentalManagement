using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ColorSeedConfiguration : IEntityTypeConfiguration<Color>
    {
      
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(
                    new Color()
                    {
                        Id = 1,
                        Name = "Black",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Color()
                    {
                        Id = 2,
                        Name = "White",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Color()
                    {
                        Id = 3,
                        Name = "Green",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Color()
                    {
                        Id = 4,
                        Name = "Blue",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Color()
                    {
                        Id = 5,
                        Name = "Silver",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Color()
                    {
                        Id = 6,
                        Name = "Red",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Color()
                    {
                        Id = 7,
                        Name = "Gray",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Color()
                    {
                        Id = 8,
                        Name = "Yellow",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    });
        }
    }
}
