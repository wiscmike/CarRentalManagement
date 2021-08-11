using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class MakesComponent
    {
        [Parameter] 
        public bool Disabled { get; set; } = false;

        [Parameter] 
        public Make make { get; set; }

        [Parameter] 
        public string ButtonText { get; set; } = "Save";

        [Parameter] 
        public EventCallback OnValidSubmit { get; set; }
    }
}
