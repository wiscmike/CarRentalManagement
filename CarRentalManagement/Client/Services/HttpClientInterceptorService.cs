using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Services
{
    public class HttpClientInterceptorService
    {
        private readonly HttpClientInterceptor _interceptorClient;
        private readonly NavigationManager _navigationManager;

        public HttpClientInterceptorService(HttpClientInterceptor interceptorClient, NavigationManager navigationManager)
        {
            _interceptorClient = interceptorClient;
            _navigationManager = navigationManager;
        }

        public void MonitorEvent() => _interceptorClient.AfterSend += _interceptorClient_AfterSend;

        private void _interceptorClient_AfterSend(object sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;

            if (!e.Response.IsSuccessStatusCode)
            {
                var responseCode = e.Response.StatusCode;

                switch (responseCode)
                {
                    case HttpStatusCode.NotFound:
                        _navigationManager.NavigateTo("/404");
                        message = "The requested resource was not found.";
                        break;

                    case HttpStatusCode.Unauthorized:
                    case HttpStatusCode.Forbidden:
                        _navigationManager.NavigateTo("/unauthorized");
                        message = "You are not authorized to access this resource.";
                        break;

                    default:
                        _navigationManager.NavigateTo("/500");
                        message = "Something went wrong, please contact the website Administrator.";
                        break;
                }
                throw new HttpRequestException(message);
            }
        }

        public void DisposeMonitorEvent() //=> _interceptorClient.AfterSend -= _interceptorClient_AfterSend;
        {
            _interceptorClient.AfterSend -= _interceptorClient_AfterSend;
        }
    }
}
