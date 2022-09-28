using Microsoft.AspNetCore.Mvc;

namespace RestAPIDDDModel.API.Controllers
{
    [Route("api/status/")]
    [ApiController]
    public class StatusController : Controller
    {
        [Route("status")]
        [HttpGet]
        public ActionResult<string> Status()
        {
            try
            {
                return Ok("Online");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error message.:" + ex);
            }
        }
    }
}