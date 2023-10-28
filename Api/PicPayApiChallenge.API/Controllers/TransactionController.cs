using Microsoft.AspNetCore.Mvc;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Types;

namespace PicPayApiChallenge.API.Controllers
{
    [ApiController]
    [Route("transactions")]
    public class TransactionController : Controller
    {
        private readonly ITransferService _service;

        public TransactionController(ITransferService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SendPix(TransactionDTO dto)
        {
            try
            {
                await this._service.SendPix(dto);

                return CreatedAtAction(nameof(SendPix), new { id = 0 });

            } catch (Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
