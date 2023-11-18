using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PicPayApiChallenge.Domain.Constants;
using PicPayApiChallenge.Domain.Contracts.Services;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Enums;
using PicPayApiChallenge.Domain.Exceptions;

namespace PicPayApiChallenge.Domain.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ILogger<TransactionService> _logger;
        private readonly ICommonUserService _commonUserService;
        private readonly ITradesmanService _tradesmanService;
        private static string _authorizationUrl;

        public TransactionService(ILogger<TransactionService> logger, ICommonUserService commonUserService, ITradesmanService tradesmanService, IOptions<ExternalUrls> options)
        {
            _logger = logger;
            _commonUserService = commonUserService;
            _tradesmanService = tradesmanService;
            _authorizationUrl = options.Value.AuthorizationUrl;
        }

        public async Task SendPix(TransactionDTO dto)
        {
            var ( value, payer, payee ) = dto;

            await IsValidTransaction(payer, value);

            await IsAuthorizedTransaction();
        }

        private async Task<bool> IsValidTransaction(Guid payerId, decimal value)
        {
            //if the payer is a trademan we cannot complete the transaction
            if (await this._tradesmanService.Exists(payerId)) throw new InvalidTransactionException("A tradesman cannot send money to others.");

            //payer have enough balance
            if(!await this._commonUserService.HasEnoughBalance(payerId, value)) throw new InvalidTransactionException("User don't have enough balance.");

            return true;
        }

        private static async Task<bool> IsAuthorizedTransaction()
        {
            HttpClient _httpClient = new();

            var response = await _httpClient.GetAsync(_authorizationUrl);

            if (!response.Content.ReadAsStringAsync().Result.Contains(AuthorizationResponse.Authorized))
            {
                throw new InvalidTransactionException("Unauthorized transaction.");
            }

            return true;
        }
    }
}
