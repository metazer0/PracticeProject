using TicketShop.EventCatalog.Models;

namespace TicketShop.EventCatalog.Repositories
{
    public interface IEventRepository
    {
        Task<List<Event>> GetAllEvents();
        Task<Event> GetEventById(int id);
    }
}
