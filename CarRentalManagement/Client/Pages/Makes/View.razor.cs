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
    public partial class View : IDisposable
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }


        [Parameter]
        public int Id { get; set; }

        private Make make = new Make();

        protected async override Task OnParametersSetAsync()
        {
            clientInterceptorService.MonitorEvent();
            make = await HttpClient.GetFromJsonAsync<Make>($"{EndPoints.MakesEndPoint}/{Id}");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
