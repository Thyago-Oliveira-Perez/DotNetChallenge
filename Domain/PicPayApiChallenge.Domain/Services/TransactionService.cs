using Microsoft.Extensions.Logging;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Interfaces;

namespace PicPayApiChallenge.Domain.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ILogger<TransactionService> logger;
        private readonly IUserRepository _userRepository;

        public TransactionService(
            ILogger<TransactionService> logger,
            IUserRepository clientRepository
            )
        {
            this.logger = logger;
            _userRepository = clientRepository;
        }

        public async Task SendPix(TransactionDTO dto)
        {
            throw new NotImplementedException();
        }

        //private bool IsValidTransaction(Guid payerId, Guid payeeId)
        //{
        //    var payer = this._userRepository.Exists(payerId);

        //    return false;
        //}
    }
}
