using Microsoft.EntityFrameworkCore;
using TicketShop.EventCatalog.Data;
using TicketShop.EventCatalog.Models;

namespace TicketShop.EventCatalog.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly DataContext _context;

        public EventRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> GetAllEvents()
        {
           return await _context.Events.ToListAsync();
        }

        public async Task<Event> GetEventById(int id)
        {
            return await _context.Events.FirstOrDefaultAsync(e => e.EventId == id);
        }
    }
}
