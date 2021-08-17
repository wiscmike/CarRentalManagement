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

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index : IDisposable
    {
        [Inject]
        private HttpClient HttpClient { get; set; }

        [Inject]
        private IJSRuntime JS { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        private List<Booking> Bookings;

        protected async override Task OnInitializedAsync()
        {
            Make make;
            Model model;

            clientInterceptorService.MonitorEvent();
            Bookings = await HttpClient.GetFromJsonAsync<List<Booking>>(EndPoints.BookingsEndPoint);

            foreach (var booking in Bookings)
            {
                make = await HttpClient.GetFromJsonAsync<Make>($"{EndPoints.MakesEndPoint}/{booking.Vehicle.MakeId}");
                booking.Vehicle.Make = make;
                model = await HttpClient.GetFromJsonAsync<Model>($"{EndPoints.ModelsEndPoint}/{booking.Vehicle.ModelId}");
                booking.Vehicle.Model = model;
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JS.InvokeVoidAsync("AddDataTable", "#bookingsTable");
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

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
            JS.InvokeVoidAsync("DisposeDataTable", "#bookingsTable");
        }
    }
}
