using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        private List<Vehicle> Vehicles;

        protected async override Task OnInitializedAsync()
        {
            Vehicles = await HttpClient.GetFromJsonAsync<List<Vehicle>>(EndPoints.VehiclesEndPoint);
        }

        private async Task Delete(int vehicleId)
        {
            var vehicle = Vehicles.FirstOrDefault(m => m.Id == vehicleId);

            if (vehicle != null)
            {
                var confirm = await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete the {vehicle.Make.Name} {vehicle.Model.Name}?");
                if (confirm)
                {
                    await HttpClient.DeleteAsync($"{EndPoints.VehiclesEndPoint}/{vehicleId}");
                    await OnInitializedAsync();
                }
            }
        }

    }
}
