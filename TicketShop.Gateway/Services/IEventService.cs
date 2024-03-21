using TicketShop.Gateway.DTOs;
using TicketShop.Gateway.Models;

namespace TicketShop.Gateway.Services
{
    public interface IEventService
    {
        Task<ServiceResponse<List<EventDTO>>> GetEventsAsync();
        Task<EventDTO> GetEventAsync(int id);
    }
}
