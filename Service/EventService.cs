using API_IPKISS.Model;
using API_IPKISS.Service.Interface;

namespace API_IPKISS.Service
{
    public class EventService : IEventService
    {
        public object HandleEvent(Event @event)
        {
            var isOriginValid = @event?.origin.GetValueOrDefault() == 200 ? throw new Exception("0") : true;

            if (@event?.amount <= 0)
                throw new Exception("Quantidade informada deve ser maior que 0");

            if (@event?.type == "deposit")
            {
                var destination = new Destination()
                {
                    id = @event.destination,
                    balance = @event.amount
                };
                return new { destination };
            }
            else if (@event?.type == "withdraw")
            {
                var origin = new Origin()
                {
                    id = @event.origin,
                    balance = 15
                };
                return new { origin };
            }
            else if (@event?.type == "transfer")
            {
                var destination = new Destination()
                {
                    id = @event.destination,
                    balance = @event.amount
                };
                var origin = new Origin()
                {
                    id = @event.origin,
                    balance = 0
                };
                return new { origin , destination };
            }
            else
            {
                throw new Exception("Verifique se os dados informados estão validos");
            }
        }

    }
}
