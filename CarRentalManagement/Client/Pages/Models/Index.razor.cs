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

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Index : IDisposable
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        private List<Model> Models;

        protected async override Task OnInitializedAsync()
        {
            clientInterceptorService.MonitorEvent();
            Models = await HttpClient.GetFromJsonAsync<List<Model>>(EndPoints.ModelsEndPoint);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JS.InvokeVoidAsync("AddDataTable", "#modelsTable");
        }

        private async Task Delete(int modelId)
        {
            var model = Models.FirstOrDefault(m => m.Id == modelId);

            if (model != null)
            {
                var confirm = await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {model.Name}?");
                if (confirm)
                {
                    var result = await HttpClient.DeleteAsync($"{EndPoints.ModelsEndPoint}/{modelId}");
                    if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        await OnInitializedAsync();
                    }
                }
            }
        }

        public void Dispose()
        {
            JS.InvokeVoidAsync("DisposeDataTable", "#modelsTable");
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
