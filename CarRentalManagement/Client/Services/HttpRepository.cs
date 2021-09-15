using CarRentalManagement.Client.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Services
{
    public class HttpRepository<T> : IDisposable, IHttpRepository<T> where T : class
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClientInterceptorService _httpClientInterceptor;

        public HttpRepository(HttpClient httpClient, HttpClientInterceptorService httpClientInterceptor)
        {
            _httpClient = httpClient;
            _httpClientInterceptor = httpClientInterceptor;
            _httpClientInterceptor.MonitorEvent();
        }
        public async Task Create(string url, T obj)
        {
          //  _httpClientInterceptor.MonitorEvent();
            await _httpClient.PostAsJsonAsync(url, obj);
        }

        public async Task Delete(string url, int id)
        {
            //_httpClientInterceptor.MonitorEvent();
            await _httpClient.DeleteAsync($"{url}/{id}");
        }

        public async Task<T> Get(string url, int id)
        {
            //_httpClientInterceptor.MonitorEvent();
            return await _httpClient.GetFromJsonAsync<T>($"{url}/{id}");
        }

        public async Task<T> GetDetails(string url, int id)
        {
            //_httpClientInterceptor.MonitorEvent();
            return await _httpClient.GetFromJsonAsync<T>($"{url}/{id}/details");
        }

        public async Task<IList<T>> Get(string url)
        {
            //_httpClientInterceptor.MonitorEvent();
            return await _httpClient.GetFromJsonAsync<List<T>>($"{url}");
        }

        public async Task Update(string url, T obj, int id)
        {
            _httpClientInterceptor.MonitorEvent();
            await _httpClient.PutAsJsonAsync($"{url}/{id}", obj);
        }

        public void Dispose()
        {
            _httpClientInterceptor.DisposeMonitorEvent();
        }

        public void Close()
        {
            if (_httpClientInterceptor != null)
            {
                Dispose();
            }
        }
    }
}
