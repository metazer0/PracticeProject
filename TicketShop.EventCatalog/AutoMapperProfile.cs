using AutoMapper;
using TicketShop.EventCatalog.DTOs;
using TicketShop.EventCatalog.Models;

namespace TicketShop.EventCatalog
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Event, EventDTO>();
            CreateMap<EventDTO, Event>();
        }
    }
}
