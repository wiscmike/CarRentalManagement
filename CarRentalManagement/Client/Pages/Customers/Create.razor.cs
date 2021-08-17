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
    public partial class Create : IDisposable
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }
        
        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        private Customer customer = new Customer();

        private async Task CreateCustomer()
        {
            clientInterceptorService.MonitorEvent();
            await HttpClient.PostAsJsonAsync<Customer>(EndPoints.CustomersEndPoint, customer);
            NavigationManager.NavigateTo("/customers/");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
