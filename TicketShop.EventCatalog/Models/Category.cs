namespace TicketShop.EventCatalog.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Event>? Events { get; set; } = new List<Event>();
    }
}

