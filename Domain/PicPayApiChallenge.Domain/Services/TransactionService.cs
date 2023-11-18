using Microsoft.Extensions.Logging;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Exceptions;
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
            var ( value, payer, payee ) = dto;

            await IsValidTransaction(payer, value);
        }

        private async Task<bool> IsValidTransaction(Guid payerId, decimal value)
        {
            //if the payer is a trademan we cannot complete the transaction
            if (await this._tradesmanRepository.Exists(payerId)) throw new InvalidTransactionException("A tradesman cannot send money to others.");

            //payer have enough balance
            if(!await this._commonUserRepository.HasBalance(payerId, value)) throw new InvalidTransactionException("User don't have enough balance.");

            return true;
        }
    }
}
