using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class View : IDisposable
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }


        [Parameter]
        public int Id { get; set; }

        private Customer customer = new Customer();

        protected async override Task OnParametersSetAsync()
        {
            clientInterceptorService.MonitorEvent();
            customer = await HttpClient.GetFromJsonAsync<Customer>($"{EndPoints.CustomersEndPoint}/{Id}");
        }

        private async Task EditCustomer()
        {
            await HttpClient.PutAsJsonAsync($"{EndPoints.CustomersEndPoint}/{Id}", customer);
            NavigationManager.NavigateTo("/customers/");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
