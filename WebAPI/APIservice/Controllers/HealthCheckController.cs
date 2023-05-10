using Microsoft.AspNetCore.Mvc;

namespace WepAppLinux.Controllers
{
    [ApiController]
    [Route("/HC")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("healthCheck")]
        public ActionResult HealthCheck()
        {
            return Ok("The API is working! You are the king! Your mark is FIVE!");
        }
    }
}