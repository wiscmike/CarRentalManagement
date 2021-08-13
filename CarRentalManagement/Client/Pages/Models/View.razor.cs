using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class View : IDisposable
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Model model = new Model();

        protected async override Task OnParametersSetAsync()
        {
            clientInterceptorService.MonitorEvent();
            model = await HttpClient.GetFromJsonAsync<Model>($"{EndPoints.ModelsEndPoint}/{Id}");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
