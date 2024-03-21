using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using TicketShop.Gateway.DTOs;
using TicketShop.Gateway.Settings;

namespace TicketShop.Gateway.Services
{
    public class ServiceRegistry : IServiceRegistry
    {
        private readonly HttpClient _httpClient;
        private readonly ApplicationSettings _applicationSettings;

        public ServiceRegistry(HttpClient httpClient, IOptions<ApplicationSettings> applicationSettings)
        {
            _httpClient = httpClient;
            _applicationSettings = applicationSettings.Value;
        }
        public async Task AddService(ServiceRegistryDTO service)
        {
            var result = await this._httpClient.PostAsJsonAsync($"{_applicationSettings.ServiceRegistryUrl}/services",service);
            result.EnsureSuccessStatusCode();
        }

        public async Task<ServiceRegistryDTO> GetService(string serviceId)
        {
            var result = await this._httpClient.GetStringAsync($"{_applicationSettings.ServiceRegistryUrl}");
            return JsonConvert.DeserializeObject<ServiceRegistryDTO>(result);
        }
    }
}
