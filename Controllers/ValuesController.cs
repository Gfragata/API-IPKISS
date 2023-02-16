using Microsoft.AspNetCore.Mvc;

namespace API_IPKISS.Controllers
{
    [ApiController]
    public class TesteController : ControllerBase
    {
        [HttpGet("balance")]
        public ActionResult balance(int account_id)
        {
            if(account_id == 1234){
                return NotFound();
            } else
            {
                return Ok();
            }
        }

        [HttpPost("reset")]
        public ActionResult reset()
        {
            return Ok();
        }
    }
}
