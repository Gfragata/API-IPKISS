using API_IPKISS.Model;

namespace API_IPKISS.Service.Interface
{
    public interface IEventService
    {
        object HandleEvent(Event @event);
    }
}
