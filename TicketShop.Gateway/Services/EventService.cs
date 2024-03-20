using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using TicketShop.Gateway.DTOs;
using TicketShop.Gateway.Settings;

namespace TicketShop.Gateway.Services
{
    public class EventService : IEventService
    {
        private readonly HttpClient _httpClient;
        private readonly IServiceRegistry _serviceRegistry;
        private readonly ApplicationSettings _appSettings;

        public EventService(HttpClient httpClient, IServiceRegistry serviceRegistry, IOptions<ApplicationSettings> appSettings)
        {
            _httpClient = httpClient;
            _serviceRegistry = serviceRegistry;
            _appSettings = appSettings.Value;
        }
        public async Task<EventDTO> GetEventAsync(int id)
        {
            var eventsUrl = await this._serviceRegistry.GetService(_appSettings.EventCatalogServiceId);
            var baseUrl = $"{eventsUrl.Origin}/events";
            var result = await this._httpClient.GetStringAsync($"{baseUrl}/{id}");
            return JsonConvert.DeserializeObject<EventDTO>(result);
        }

        public async Task<List<EventDTO>> GetEventsAsync(int id, string name)
        {
            var eventsUrl = await this._serviceRegistry.GetService(_appSettings.EventCatalogServiceId);
            var baseUrl = $"{eventsUrl.Origin}/events";
            var result = await this._httpClient.GetStringAsync(baseUrl);
            return JsonConvert.DeserializeObject<List<EventDTO>>(result);
        }
    }
}
