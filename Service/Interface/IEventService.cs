using API_IPKISS.DTO;

namespace API_IPKISS.Service.Interface
{
    public interface IEventService
    {
        object HandleEvent(Event @event);
    }
}
