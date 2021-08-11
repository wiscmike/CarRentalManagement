using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class View
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Customer customer = new Customer();

        protected async override Task OnParametersSetAsync()
        {
            customer = await HttpClient.GetFromJsonAsync<Customer>($"{EndPoints.CustomersEndPoint}/{Id}");
        }

        private async Task EditCustomer()
        {
            await HttpClient.PutAsJsonAsync($"{EndPoints.CustomersEndPoint}/{Id}", customer);
            NavigationManager.NavigateTo("/customers/");
        }

    }
}
