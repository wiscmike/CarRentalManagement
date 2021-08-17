using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index : IDisposable
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }


        private List<Vehicle> Vehicles;

        protected async override Task OnInitializedAsync()
        {
            clientInterceptorService.MonitorEvent();
            Vehicles = await HttpClient.GetFromJsonAsync<List<Vehicle>>(EndPoints.VehiclesEndPoint);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JS.InvokeVoidAsync("AddDataTable", "#vehiclesTable");
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

        public void Dispose()
        {
            JS.InvokeVoidAsync("DisposeDataTable", "#vehiclesTable");
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
