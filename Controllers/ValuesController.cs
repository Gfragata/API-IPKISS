using API_IPKISS.Model;
using API_IPKISS.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_IPKISS.Controllers
{
    [ApiController]
    public class ValueController : ControllerBase
    {
        public readonly IBalanceService _balanceService;
        public readonly IEventService _eventService;

        public ValueController(IBalanceService balanceService, IEventService eventService)
        {
            _balanceService = balanceService;
            _eventService = eventService;
        }

        [HttpPost("reset")]
        public ActionResult reset()
        {
            return Ok();
        }

        [HttpGet("balance")]
        public ActionResult GetBalance(int account_id)
        {
            try
            {
                var retorno = _balanceService.GetBalance(account_id);
                if (!retorno) return NotFound();
                return Ok(20);
            }
            catch (Exception)
            {
                return NotFound(0);
            }


        }

        [HttpPost("event")]
        public ActionResult PostEvent(Event @event)
        {
            try
            {
                var retorno = _eventService.HandleEvent(@event);
                if (string.IsNullOrEmpty(retorno.ToString())) return NotFound();
                return new ObjectResult(retorno) { StatusCode = StatusCodes.Status201Created };
            }
            catch (Exception)
            {

                return NotFound(0);
            }
        }
    }
}
