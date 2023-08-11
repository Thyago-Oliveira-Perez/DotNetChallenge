using Microsoft.AspNetCore.Mvc;

namespace PicPayApiChallenge.API.Controllers
{
    [ApiController]
    [Route("keys")]
    public class KeysController : ControllerBase
    {
        private readonly ILogger<KeysController> _logger;

        public KeysController(ILogger<KeysController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}