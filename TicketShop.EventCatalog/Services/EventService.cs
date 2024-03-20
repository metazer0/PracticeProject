using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketShop.EventCatalog.Data;
using TicketShop.EventCatalog.DTOs;
using TicketShop.EventCatalog.Models;
using TicketShop.EventCatalog.Repositories;

namespace TicketShop.EventCatalog.Services
{
    public class EventService : IEventService
    {
        private readonly IMapper _mapper;
        private readonly IEventRepository _eventRepository;

        public EventService(IMapper mapper, IEventRepository eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<ServiceResponse<List<EventDTO>>> GetAllEvents()
        {
            var serviceResponse = new ServiceResponse<List<EventDTO>>();
            var events = await _eventRepository.GetAllEvents();
            serviceResponse.Data = events.Select(e => _mapper.Map<EventDTO>(e)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<EventDTO>> GetEventById(int id)
        {
            var serviceResponse = new ServiceResponse<EventDTO>();
            var evt = await _eventRepository.GetEventById(id);
            serviceResponse.Data = _mapper.Map<EventDTO>(evt);
            return serviceResponse;
        }
    }
}
