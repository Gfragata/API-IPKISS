using API_IPKISS.DTO;
using API_IPKISS.Model;
using API_IPKISS.Service.Interface;

namespace API_IPKISS.Service
{
    public class EventService : IEventService
    {
        public object HandleEvent(Event @event)
        {
            var isOriginValid = @event?.origin.GetValueOrDefault() == 200 ? false : true;

            if (@event?.amount <= 0)
                throw new Exception("Quantidade informada deve ser maior que 0");

            if (@event?.type == "deposit")
            {
                var destino = new Destination(){
                    id = @event.destination,
                    balance = @event.amount,
                };
                return destino;
            }
            else if (@event?.type == "withdraw")
            {
                var retorno = isOriginValid ? true : throw new Exception("0");
                return retorno;
            }
            else if (@event?.type == "transfer")
            {
                var retorno = isOriginValid ? true : throw new Exception("0");
                return retorno;
            }
            else
            {
                throw new Exception("Verifique se os dados informados estão validos");
            }
        }

    }
}
