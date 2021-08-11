using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Make : BaseDomainModel
    {
        [Required]
        [StringLength(35, MinimumLength = 4)]
        public string Name { get; set; }
    }
}
