using Microsoft.Extensions.Logging;
using PicPayApiChallenge.Domain.Contracts.Repositories;
using PicPayApiChallenge.Domain.Contracts.Services;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Exceptions;

namespace PicPayApiChallenge.Domain.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ILogger<TransactionService> logger;
        private readonly ICommonUserService _commonUserService;
        private readonly ITradesmanService _tradesmanService;

        public TransactionService(ILogger<TransactionService> logger, ICommonUserService commonUserService, ITradesmanService tradesmanRepository)
        {
            this.logger = logger;
            _commonUserService = commonUserService;
            _tradesmanService = tradesmanRepository;
        }

        public async Task SendPix(TransactionDTO dto)
        {
            var ( value, payer, payee ) = dto;

            await IsValidTransaction(payer, value);
        }

        private async Task<bool> IsValidTransaction(Guid payerId, decimal value)
        {
            //if the payer is a trademan we cannot complete the transaction
            if (await this._tradesmanService.Exists(payerId)) throw new InvalidTransactionException("A tradesman cannot send money to others.");

            //payer have enough balance
            if(!await this._commonUserService.HasEnoughBalance(payerId, value)) throw new InvalidTransactionException("User don't have enough balance.");

            return true;
        }
    }
}
