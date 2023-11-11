using Microsoft.Extensions.Logging;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Interfaces;

namespace PicPayApiChallenge.Domain.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ILogger<TransactionService> logger;
        private readonly ICommonUserRepository _commonUserRepository;
        private readonly ITradesmanRepository _tradesmanRepository;

        public TransactionService(ILogger<TransactionService> logger, ICommonUserRepository commonUserRepository, ITradesmanRepository tradesmanRepository)
        {
            this.logger = logger;
            _commonUserRepository = commonUserRepository;
            _tradesmanRepository = tradesmanRepository;
        }

        public async Task SendPix(TransactionDTO dto)
        {
            throw new NotImplementedException();
        }

        private bool IsValidTransaction(Guid payerId, Guid payeeId)
        {
            var payer = this._tradesmanRepository.Exists(payerId);

            return false;
        }
    }
}
