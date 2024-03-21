using Microsoft.AspNetCore.Mvc;
using TicketShop.Gateway.Services;

namespace TicketShop.Gateway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<ActionResult> GetEvents()
        {
            var results = await _eventService.GetEventsAsync();
            return Ok(results); 
        }
    }
}
