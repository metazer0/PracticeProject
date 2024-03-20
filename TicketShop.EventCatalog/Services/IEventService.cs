using TicketShop.EventCatalog.DTOs;
using TicketShop.EventCatalog.Models;

namespace TicketShop.EventCatalog.Services
{
    public interface IEventService
    {
        Task<ServiceResponse<List<EventDTO>>> GetAllEvents();
        Task<ServiceResponse<EventDTO>> GetEventById(int id);
    }
}
