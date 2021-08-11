using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        private List<Booking> Bookings;

        protected async override Task OnInitializedAsync()
        {
            Make make;
            Model model;

            Bookings = await HttpClient.GetFromJsonAsync<List<Booking>>(EndPoints.BookingsEndPoint);

            foreach (var booking in Bookings)
            {
                make = await HttpClient.GetFromJsonAsync<Make>($"{EndPoints.MakesEndPoint}/{booking.Vehicle.MakeId}");
                booking.Vehicle.Make = make;
                model = await HttpClient.GetFromJsonAsync<Model>($"{EndPoints.ModelsEndPoint}/{booking.Vehicle.ModelId}");
                booking.Vehicle.Model = model;
            }
        }

        private async Task Delete(int bookingId)
        {
            var booking = Bookings.FirstOrDefault(m => m.Id == bookingId);

            if (booking != null)
            {
                var confirm = await JS.InvokeAsync<bool>("confirm", $"Are you sure you want to delete the selected booking?");
                if (confirm)
                {
                    await HttpClient.DeleteAsync($"{EndPoints.BookingsEndPoint}/{bookingId}");
                    await OnInitializedAsync();
                }
            }
        }
    }
}
