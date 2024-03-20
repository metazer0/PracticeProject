using Microsoft.AspNetCore.Mvc;
using TicketShop.EventCatalog.DTOs;
using TicketShop.EventCatalog.Models;
using TicketShop.EventCatalog.Services;

namespace TicketShop.EventCatalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController: ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<EventDTO>>>> GetEvents()
        {
            return Ok(await _eventService.GetAllEvents());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<EventDTO>>> GetEvent(int id)
        {
            return Ok(await _eventService.GetEventById(id));
        }
    }
}
