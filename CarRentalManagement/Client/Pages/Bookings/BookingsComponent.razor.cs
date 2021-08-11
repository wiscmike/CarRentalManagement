using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class BookingsComponent
    {
        [Inject]
        HttpClient HttpClient { get; set; }

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
            Vehicles = await HttpClient.GetFromJsonAsync<List<Vehicle>>($"{EndPoints.VehiclesEndPoint}");
            Customers = await HttpClient.GetFromJsonAsync<List<Customer>>($"{EndPoints.CustomersEndPoint}");
        }
    }
}
