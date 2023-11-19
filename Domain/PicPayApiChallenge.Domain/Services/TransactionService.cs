using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PicPayApiChallenge.Domain.Constants;
using PicPayApiChallenge.Domain.Contracts.Repositories;
using PicPayApiChallenge.Domain.Contracts.Services;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Enums;
using PicPayApiChallenge.Domain.Exceptions;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Domain.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ILogger<TransactionService> _logger;
        private readonly IUserService _userService;
        private readonly ITransactionRepository _repository;
        private static string _authorizationUrl;

        public TransactionService(ILogger<TransactionService> logger, IUserService commonUserService, IOptions<ExternalUrls> options, ITransactionRepository repository)
        {
            _logger = logger;
            _userService = commonUserService;
            _authorizationUrl = options.Value.AuthorizationUrl;
            _repository = repository;
        }

        public async Task SendPix(TransactionDTO dto)
        {
            var ( value, payer, payee ) = dto;

            await IsValidTransaction(payer, value);

            await IsAuthorizedTransaction();

            await CreateTransaction(payer, payee, value);
        }

        private async Task<bool> IsValidTransaction(Guid payerId, decimal value)
        {
            //if the payer is a trademan we cannot complete the transaction
            if (await this._userService.Exists(payerId)) throw new InvalidTransactionException("A tradesman cannot send money to others.");

            //payer have enough balance
            if(!await this._userService.HasEnoughBalance(payerId, value)) throw new InvalidTransactionException("User don't have enough balance.");

            return true;
        }

        private static async Task<bool> IsAuthorizedTransaction()
        {
            HttpClient _httpClient = new();

            var response = await _httpClient.GetAsync(_authorizationUrl);

            if (!response.Content.ReadAsStringAsync().Result.Contains(AuthorizationResponse.Authorized))
            {
                throw new UnauthorizedTransactionException();
            }

            return true;
        }

        private async Task CreateTransaction(Guid payer, Guid payee, decimal amount)
        {
            try
            {
                await _repository.Add(new TransactionEntity()
                {
                    Amount = amount,
                    Date = DateTime.Now,
                    PayerId = payer,
                    PayeeId = payee,
                });
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex.Message);
                throw new CreateTransactionException(ex.Message);
            }
        }
    }
}
