using System.Collections.Generic;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }

        public int ModelId { get; set; }

        public virtual Model Model { get; set; }

        public int MakeId { get; set; }

        public virtual Make Make { get; set; }

        public int ColorId { get; set; }

        public virtual Color Color { get; set; }

        public string VIN { get; set; }

        public string LicenseNumber { get; set; }

        public double RentalRate { get; set; }

        public virtual List<Booking> Bookings { get; set; }
    }
}
