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

        private Make make = new Make();

        protected async override Task OnParametersSetAsync()
        {
            clientInterceptorService.MonitorEvent();
            make = await HttpClient.GetFromJsonAsync<Make>($"{EndPoints.MakesEndPoint}/{Id}");
        }

        private async Task EditMake()
        {
            await HttpClient.PutAsJsonAsync($"{EndPoints.MakesEndPoint}/{Id}", make);
            NavigationManager.NavigateTo("/makes/");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
