using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Create
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        private Make make = new Make();

        private async Task CreateMake()
        {
            await HttpClient.PostAsJsonAsync<Make>(EndPoints.MakesEndPoint, make);
            NavigationManager.NavigateTo("/makes/");
        }
    }
}
