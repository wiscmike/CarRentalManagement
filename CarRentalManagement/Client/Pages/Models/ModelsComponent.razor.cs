using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class ModelsComponent
    {
        [Parameter] 
        public bool Disabled { get; set; } = false;

        [Parameter] 
        public Model model { get; set; }

        [Parameter] 
        public string ButtonText { get; set; } = "Save";

        [Parameter] 
        public EventCallback OnValidSubmit { get; set; }
    }
}
