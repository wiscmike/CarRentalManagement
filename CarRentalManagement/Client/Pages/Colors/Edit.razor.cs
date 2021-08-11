using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Edit
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        [Parameter] 
        public int Id { get; set; }
        
        private Color color = new Color();

        protected async override Task OnParametersSetAsync()
        {
            color = await HttpClient.GetFromJsonAsync<Color>($"{EndPoints.ColorsEndPoint}/{Id}");
        }

        private async Task EditColor()
        {
            await HttpClient.PutAsJsonAsync($"{EndPoints.ColorsEndPoint}/{Id}", color);
            NavigationManager.NavigateTo("/colors/");
        }


    }
}
