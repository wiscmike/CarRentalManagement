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
    public partial class Index
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        private List<Make> Makes;

        protected async override Task OnInitializedAsync()
        {
            Makes = await HttpClient.GetFromJsonAsync<List<Make>>(EndPoints.MakesEndPoint);
        }

        private async Task Delete(int makeId)
        {
            var make = Makes.FirstOrDefault(m => m.Id == makeId);

            if (make != null)
            {
                var confirm = await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {make.Name}?");
                if (confirm)
                {
                    await HttpClient.DeleteAsync($"{EndPoints.MakesEndPoint}/{makeId}");
                    await OnInitializedAsync();
                }
            }
        }
    }
}
