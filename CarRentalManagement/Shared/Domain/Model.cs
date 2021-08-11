using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Model : BaseDomainModel
    {
        [Required]
        [StringLength(35, MinimumLength = 2)]
        public string Name { get; set; }
    }
}
