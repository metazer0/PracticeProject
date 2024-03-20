using Microsoft.AspNetCore.Mvc;
using TicketShop.Gateway.Services;

namespace TicketShop.Gateway.Controllers
{
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<ActionResult> GetEvents([FromQuery] int id, [FromQuery] string name)
        {
            var results = await _eventService.GetEventsAsync(id, name);
            return Ok(results); 
        }
    }
}
