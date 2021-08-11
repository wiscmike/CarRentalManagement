using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Create
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private Color color = new Color();

        private async Task CreateColor()
        {
            await HttpClient.PostAsJsonAsync<Color>(EndPoints.ColorsEndPoint, color);
            NavigationManager.NavigateTo("/colors/");
        }
    }
}
