using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Create : IDisposable
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        private Make make = new Make();

        private async Task CreateMake()
        {
            clientInterceptorService.MonitorEvent();
            await HttpClient.PostAsJsonAsync<Make>(EndPoints.MakesEndPoint, make);
            NavigationManager.NavigateTo("/makes/");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
