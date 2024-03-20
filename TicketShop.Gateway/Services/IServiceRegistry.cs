using TicketShop.Gateway.DTOs;

namespace TicketShop.Gateway.Services
{
    public interface IServiceRegistry
    {
        Task<ServiceRegistryDTO> GetService(string serviceId);
        Task AddService(ServiceRegistryDTO service);
    }
}
