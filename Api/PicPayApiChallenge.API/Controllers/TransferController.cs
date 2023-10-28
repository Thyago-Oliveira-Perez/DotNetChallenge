using Microsoft.AspNetCore.Mvc;

namespace PicPayApiChallenge.API.Controllers
{
    [ApiController]
    [Route("keys")]
    public class TransferController : Controller
    {
        private readonly ILogger<TransferController> _logger;

        public TransferController(ILogger<TransferController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult SendPix(int id, IFormCollection collection)
        {
            throw new NotImplementedException();
        }
    }
}
