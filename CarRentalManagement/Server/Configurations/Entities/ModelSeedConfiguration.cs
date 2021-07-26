using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                    new Model()
                    {
                        Id = 1,
                        Name = "Pilot",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Model()
                    {
                        Id = 2,
                        Name = "Accord",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Model()
                    {
                        Id = 3,
                        Name = "Outback",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Model()
                    {
                        Id = 4,
                        Name = "Forester",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Model()
                    {
                        Id = 5,
                        Name = "Model Y",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Model()
                    {
                        Id = 6,
                        Name = "Model 3",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Model()
                    {
                        Id = 7,
                        Name = "Mustang Shelby GT500",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Model()
                    {
                        Id = 8,
                        Name = "F-150",
                        DateCreated = DateTime.Now,
                        CreatedBy = "System",
                        DateUpdated = DateTime.Now,
                        UpdatedBy = "System",
                    });

        }
    }
}
