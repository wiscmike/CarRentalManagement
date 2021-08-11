using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private Customer customer = new Customer();

        private async Task CreateCustomer()
        {
            await HttpClient.PostAsJsonAsync<Customer>(EndPoints.CustomersEndPoint, customer);
            NavigationManager.NavigateTo("/customers/");
        }
    }
}
