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
    public partial class Create : IDisposable
    {
        [Inject]
        private HttpClient HttpClient { get; set; }
        
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        private Booking booking = new Booking()
        {
            DateOut = DateTime.Now.Date
        };

        private async Task CreateBooking()
        {
            clientInterceptorService.MonitorEvent();
            await HttpClient.PostAsJsonAsync<Booking>(EndPoints.BookingsEndPoint, booking);
            NavigationManager.NavigateTo("/bookings/");
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
