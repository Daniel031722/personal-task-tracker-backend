using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet("getHealth")]
        public IActionResult GetHealth()
        {
            return Ok("API is healthy ✅");
        }
    }
}
