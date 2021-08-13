﻿using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Edit : IDisposable
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        [Parameter]
        public int Id { get; set; }

        private Model model = new Model();

        protected async override Task OnParametersSetAsync()
        {
            clientInterceptorService.MonitorEvent();
            model = await HttpClient.GetFromJsonAsync<Model>($"{EndPoints.ModelsEndPoint}/{Id}");
        }

        private async Task EditModel()
        {
            var result = await HttpClient.PutAsJsonAsync($"{EndPoints.ModelsEndPoint}/{Id}", model);
            if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                NavigationManager.NavigateTo("/models/");
            }
        }

        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
