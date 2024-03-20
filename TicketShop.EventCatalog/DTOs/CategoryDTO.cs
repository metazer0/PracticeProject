using TicketShop.EventCatalog.Models;

namespace TicketShop.EventCatalog.DTOs
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Event>? Events { get; set; }
    }
}
