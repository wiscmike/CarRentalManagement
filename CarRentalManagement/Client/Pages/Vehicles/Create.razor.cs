using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Create : IDisposable
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        private Vehicle vehicle = new Vehicle();

        private List<Make> Makes;
        private List<Model> Models;
        private List<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            clientInterceptorService.MonitorEvent();
            Makes = await HttpClient.GetFromJsonAsync<List<Make>>($"{EndPoints.MakesEndPoint}");
            Models = await HttpClient.GetFromJsonAsync<List<Model>>($"{EndPoints.ModelsEndPoint}");
            Colors = await HttpClient.GetFromJsonAsync<List<Color>>($"{EndPoints.ColorsEndPoint}");
        }

        private async Task CreateVehicle()
        {
            var result = await HttpClient.PostAsJsonAsync<Vehicle>(EndPoints.VehiclesEndPoint, vehicle);
            if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                NavigationManager.NavigateTo("/vehicles/");
            }
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
