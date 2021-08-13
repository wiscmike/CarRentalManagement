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
    public partial class VehiclesComponent : IDisposable
    {
        [Inject] 
        HttpClient HttpClient { get; set; }

        [Parameter] 
        public bool Disabled { get; set; } = false;

        [Parameter] 
        public Vehicle vehicle { get; set; }

        [Parameter] 
        public string ButtonText { get; set; } = "Save";

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        [Parameter] 
        public EventCallback OnValidSubmit { get; set; }

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

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
