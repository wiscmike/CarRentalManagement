using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Edit
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Model model = new Model();

        protected async override Task OnParametersSetAsync()
        {
            model = await HttpClient.GetFromJsonAsync<Model>($"{EndPoints.ModelsEndPoint}/{Id}");
        }

        private async Task EditModel()
        {
            await HttpClient.PutAsJsonAsync($"{EndPoints.ModelsEndPoint}/{Id}", model);
            NavigationManager.NavigateTo("/models/");
        }
    }
}
