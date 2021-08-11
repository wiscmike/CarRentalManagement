using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class ColorsComponent
    {
        [Parameter] 
        public bool Disabled { get; set; } = false;
        
        [Parameter] 
        public Color color { get; set; }
        
        [Parameter] 
        public string ButtonText { get; set; } = "Save";
        
        [Parameter] 
        public EventCallback OnValidSubmit { get; set; }
    }
}
