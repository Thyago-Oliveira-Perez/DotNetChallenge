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

        public TransactionService(
            ILogger<TransactionService> logger, 
            IClientRepository clientRepository, 
            IShopKeeperRepository shopKeeperRepository)
        {
            this.logger = logger;
            _clientRepository = clientRepository;
            _shopKeeperRepository = shopKeeperRepository;
        }

        public async Task SendPix(TransactionDTO dto)
        {
            throw new NotImplementedException();
        }

        private bool IsValidTransaction(Guid payerId, Guid payeeId)
        {
            var payer = this._clientRepository.Exists(payerId);
            var payee = this._shopKeeperRepository.Exists(payeeId);

            return false;
        }
    }
}
