
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApiWithStaticFiles.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from the API!" });
        }
    }
}
