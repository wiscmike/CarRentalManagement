using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Create
    {
        [Inject]
        private HttpClient HttpClient { get; set; }
        
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private Booking booking = new Booking()
        {
            DateOut = DateTime.Now.Date
        };

        private async Task CreateBooking()
        {
            await HttpClient.PostAsJsonAsync<Booking>(EndPoints.BookingsEndPoint, booking);
            NavigationManager.NavigateTo("/bookings/");
        }
    }
}
