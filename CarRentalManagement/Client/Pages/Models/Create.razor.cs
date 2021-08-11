using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Create
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        private Model model = new Model();

        private async Task CreateModel()
        {
            await HttpClient.PostAsJsonAsync<Model>(EndPoints.ModelsEndPoint, model);
            NavigationManager.NavigateTo("/models/");
        }
    }
}
