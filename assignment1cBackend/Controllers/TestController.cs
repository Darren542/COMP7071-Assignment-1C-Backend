using Microsoft.AspNetCore.Mvc;

namespace assignment1cBackend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, from the ASP.Net Core Web API");
        }   
    }
}
