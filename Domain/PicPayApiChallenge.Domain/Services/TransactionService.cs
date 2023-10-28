using Microsoft.Extensions.Logging;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Interfaces;

namespace PicPayApiChallenge.Domain.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ILogger<TransactionService> logger;
        private readonly IClientRepository _clientRepository;
        private readonly IShopKeeperRepository _shopKeeperRepository;

        public TransactionService(ILogger<TransactionService> logger)
        {
            this.logger = logger;
        }

        public async Task SendPix(TransactionDTO dto)
        {
            throw new NotImplementedException();
        }

        private static bool IsValidTransaction(Guid payerId, Guid payeeId)
        {


            return false;
        }
    }
}
