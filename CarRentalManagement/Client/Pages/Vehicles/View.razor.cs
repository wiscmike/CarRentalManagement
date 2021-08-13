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
    public partial class View : IDisposable
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }


        [Parameter]
        public int Id { get; set; }

        Vehicle vehicle = new Vehicle();

        protected async override Task OnParametersSetAsync()
        {
            clientInterceptorService.MonitorEvent();
            vehicle = await HttpClient.GetFromJsonAsync<Vehicle>($"{EndPoints.VehiclesEndPoint}/{Id}");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
