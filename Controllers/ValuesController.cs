using API_IPKISS.DTO;
using API_IPKISS.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_IPKISS.Controllers
{
    [Route("values")]
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
                return Ok();
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
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
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
    }
}
