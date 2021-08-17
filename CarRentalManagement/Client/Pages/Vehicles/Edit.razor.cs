using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Edit : IDisposable
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Vehicle vehicle = new Vehicle();

        protected async override Task OnParametersSetAsync()
        {
            clientInterceptorService.MonitorEvent();
            vehicle = await HttpClient.GetFromJsonAsync<Vehicle>($"{EndPoints.VehiclesEndPoint}/{Id}");
        }

        private async Task EditVehicle()
        {
            await HttpClient.PutAsJsonAsync($"{EndPoints.VehiclesEndPoint}/{Id}", vehicle);
            NavigationManager.NavigateTo("/vehicles/");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
