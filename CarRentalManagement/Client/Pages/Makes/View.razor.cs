using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class View
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Make make = new Make();

        protected async override Task OnParametersSetAsync()
        {
            make = await HttpClient.GetFromJsonAsync<Make>($"{EndPoints.MakesEndPoint}/{Id}");
        }

    }
}
