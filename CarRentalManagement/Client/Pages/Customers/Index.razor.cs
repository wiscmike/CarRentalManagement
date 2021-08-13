using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Index : IDisposable
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }


        private List<Customer> Customers;

        protected async override Task OnInitializedAsync()
        {
            clientInterceptorService.MonitorEvent();
            Customers = await HttpClient.GetFromJsonAsync<List<Customer>>(EndPoints.CustomersEndPoint);
        }

        private async Task Delete(int customerId)
        {
            var customer = Customers.FirstOrDefault(m => m.Id == customerId);

            if (customer != null)
            {
                var confirm = await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {customer.EmailAddress}?");
                if (confirm)
                {
                    var result = await HttpClient.DeleteAsync($"{EndPoints.CustomersEndPoint}/{customerId}");
                    if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        await OnInitializedAsync();
                    }
                }
            }
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
