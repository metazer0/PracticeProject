using TicketShop.Gateway.DTOs;

namespace TicketShop.Gateway.Services
{
    public interface IEventService
    {
        Task<List<EventDTO>> GetEventsAsync(int id, string name);
        Task<EventDTO> GetEventAsync(int id);
    }
}
