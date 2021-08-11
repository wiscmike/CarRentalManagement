using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class Edit
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Make make = new Make();

        protected async override Task OnParametersSetAsync()
        {
            make = await HttpClient.GetFromJsonAsync<Make>($"{EndPoints.MakesEndPoint}/{Id}");
        }

        private async Task EditMake()
        {
            await HttpClient.PutAsJsonAsync($"{EndPoints.MakesEndPoint}/{Id}", make);
            NavigationManager.NavigateTo("/makes/");
        }
    }
}
