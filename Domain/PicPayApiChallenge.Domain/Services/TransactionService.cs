using Microsoft.Extensions.Logging;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Types;

namespace PicPayApiChallenge.Domain.Services
{
    public class TransferService : ITransferService
    {
        private readonly ILogger<TransferService> logger;

        public TransferService(ILogger<TransferService> logger)
        {
            this.logger = logger;
        }

        public async Task SendPix(TransactionDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
