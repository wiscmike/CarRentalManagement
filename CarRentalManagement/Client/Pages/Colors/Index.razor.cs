using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Index
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        private List<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            Colors = await HttpClient.GetFromJsonAsync<List<Color>>(EndPoints.ColorsEndPoint);
        }

        private async Task Delete(int colorId)
        {
            var color = Colors.FirstOrDefault(m => m.Id == colorId);

            if (color != null)
            {
                var confirm = await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {color.Name}?");
                if (confirm)
                {
                    await HttpClient.DeleteAsync($"{EndPoints.ColorsEndPoint}/{colorId}");
                    await OnInitializedAsync();
                }
            }
        }
    }
}
