using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class VehiclesComponent : IDisposable
    {
        [Inject] 
        HttpClient HttpClient { get; set; }

        [Parameter] 
        public bool Disabled { get; set; } = false;

        [Parameter]
        public bool DisabledForEdit { get; set; } = false;

        [Parameter] 
        public Vehicle vehicle { get; set; }

        [Parameter] 
        public string ButtonText { get; set; } = "Save";

        [Inject]
        private HttpClientInterceptorService clientInterceptorService { get; set; }

        [Parameter] 
        public EventCallback OnValidSubmit { get; set; }

        private List<Make> Makes;
        private List<Model> Models;
        private List<Color> Colors;
        private string UploadFileWarning;

        protected async override Task OnInitializedAsync()
        {
            clientInterceptorService.MonitorEvent();
            Makes = await HttpClient.GetFromJsonAsync<List<Make>>($"{EndPoints.MakesEndPoint}");
            Models = await HttpClient.GetFromJsonAsync<List<Model>>($"{EndPoints.ModelsEndPoint}");
            Colors = await HttpClient.GetFromJsonAsync<List<Color>>($"{EndPoints.ColorsEndPoint}");
        }

        private async void HandleFileSelection(InputFileChangeEventArgs e)
        {
            var file = e.File;
            
            if (file != null)
            {
                var ext = System.IO.Path.GetExtension(file.Name);
                if (ext.Equals(".jpg", StringComparison.OrdinalIgnoreCase)
                    || ext.Equals(".png", StringComparison.OrdinalIgnoreCase)
                    || ext.Equals(".jpeg", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        var picId = Guid.NewGuid().ToString().Replace("-", string.Empty);
                        vehicle.VehicleImageName = $"{picId}{ext}";
                        vehicle.VehicleImage = new byte[file.Size];
                        await file.OpenReadStream().ReadAsync(vehicle.VehicleImage);
                        UploadFileWarning = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        UploadFileWarning = ex.Message;
                    }
                }
            }
            else
            {
                UploadFileWarning = "Please select a valid image file (*.jpg | *.png)";
            }
        }
        
        public void Dispose()
        {
            clientInterceptorService.DisposeMonitorEvent();
        }
    }
}
