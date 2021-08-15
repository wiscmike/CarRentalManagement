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

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Index : IDisposable
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        private List<Make> Makes;

        protected async override Task OnInitializedAsync()
        {
            clientInterceptorService.MonitorEvent();
            Makes = await HttpClient.GetFromJsonAsync<List<Make>>(EndPoints.MakesEndPoint);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JS.InvokeVoidAsync("AddDataTable", "#makesTable");
        }

        private async Task Delete(int makeId)
        {
            var make = Makes.FirstOrDefault(m => m.Id == makeId);

            if (make != null)
            {
                var confirm = await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {make.Name}?");
                if (confirm)
                {
                    var result = await HttpClient.DeleteAsync($"{EndPoints.MakesEndPoint}/{makeId}");
                    if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        await OnInitializedAsync();
                    }
                }
            }
        }

        public void Dispose()
        {
            JS.InvokeVoidAsync("DisposeDataTable", "#makesTable");
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
