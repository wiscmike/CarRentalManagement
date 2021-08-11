using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Index
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        private List<Model> Models;

        protected async override Task OnInitializedAsync()
        {
            Models = await HttpClient.GetFromJsonAsync<List<Model>>(EndPoints.ModelsEndPoint);
        }

        private async Task Delete(int modelId)
        {
            var model = Models.FirstOrDefault(m => m.Id == modelId);

            if (model != null)
            {
                var confirm = await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {model.Name}?");
                if (confirm)
                {
                    await HttpClient.DeleteAsync($"{EndPoints.ModelsEndPoint}/{modelId}");
                    await OnInitializedAsync();
                }
            }
        }
    }
}
