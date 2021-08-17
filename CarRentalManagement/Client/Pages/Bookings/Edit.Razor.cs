using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Edit : IDisposable
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        [Parameter] 
        public int Id { get; set; }

        private Booking booking = new Booking();

        protected async override Task OnParametersSetAsync()
        {
            clientInterceptorService.MonitorEvent();
            booking = await HttpClient.GetFromJsonAsync<Booking>($"{EndPoints.BookingsEndPoint}/{Id}");
        }

        private async Task EditBooking()
        {
            await HttpClient.PutAsJsonAsync($"{EndPoints.BookingsEndPoint}/{Id}", booking);
            NavigationManager.NavigateTo("/bookings/");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
