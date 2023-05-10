using Microsoft.AspNetCore.Mvc;

namespace WepAppLinux.Controllers
{
    [ApiController]
    [Route("/healthcheck")]
    public class HealthCheckController : ControllerBase
    {
        public ActionResult HealthCheck()
        {
            return Ok("The API is working! You are the king! Your mark is FIVE!");
        }
    }
}