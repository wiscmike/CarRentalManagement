using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class BookingsComponent : IDisposable
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        [Parameter]
        public bool Disabled { get; set; } = false;

        [Parameter]
        public Booking booking { get; set; }

        [Parameter]
        public string ButtonText { get; set; } = "Save";

        [Parameter]
        public EventCallback OnValidSubmit { get; set; }

        private List<Vehicle> Vehicles;
        private List<Customer> Customers;

        protected async override Task OnInitializedAsync()
        {
            clientInterceptorService.MonitorEvent();
            Vehicles = await HttpClient.GetFromJsonAsync<List<Vehicle>>($"{EndPoints.VehiclesEndPoint}");
            Customers = await HttpClient.GetFromJsonAsync<List<Customer>>($"{EndPoints.CustomersEndPoint}");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
