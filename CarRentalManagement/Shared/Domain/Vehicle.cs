using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        [Required]
        public int Year { get; set; }

        [Required]
        public int ModelId { get; set; }

        public virtual Model Model { get; set; }

        [Required]
        public int MakeId { get; set; }

        public virtual Make Make { get; set; }

        [Required]
        public int ColorId { get; set; }

        public virtual Color Color { get; set; }

        public string VIN { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5)]
        public string LicenseNumber { get; set; }

        [Required]
        public double RentalRate { get; set; }

        public virtual List<Booking> Bookings { get; set; }

        [NotMapped]
        public byte[] VehicleImage { get; set; }

        public string VehicleImageName { get; set; }
    }
}
