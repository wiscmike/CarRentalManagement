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

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Index : IDisposable
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        private List<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            clientInterceptorService.MonitorEvent();
            Colors = await HttpClient.GetFromJsonAsync<List<Color>>(EndPoints.ColorsEndPoint);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JS.InvokeVoidAsync("AddDataTable", "#colorsTable");
        }

        private async Task Delete(int colorId)
        {
            var color = Colors.FirstOrDefault(m => m.Id == colorId);
           
            if (color != null)
            {
                var confirm = await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {color.Name}?");
                if (confirm)
                {
                    var result = await HttpClient.DeleteAsync($"{EndPoints.ColorsEndPoint}/{colorId}");
                    if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        await OnInitializedAsync();
                    }
                }
            }
        }

        public void Dispose()
        {
            JS.InvokeVoidAsync("DisposeDataTable", "#colorsTable");
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
