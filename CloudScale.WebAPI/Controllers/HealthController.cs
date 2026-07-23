namespace CloudScale.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult Get()
        {
            return Ok("Healthy");
        }
    }
}
