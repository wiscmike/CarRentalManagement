using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class CustomersComponent
    {
        [Parameter] 
        public bool Disabled { get; set; } = false;
        
        [Parameter] 
        public Customer customer { get; set; }

        [Parameter] 
        public string ButtonText { get; set; } = "Save";

        [Parameter] 
        public EventCallback OnValidSubmit { get; set; }
    }
}
