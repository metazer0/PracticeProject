namespace TicketShop.EventCatalog.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string Artist { get; set; } = string.Empty ;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
