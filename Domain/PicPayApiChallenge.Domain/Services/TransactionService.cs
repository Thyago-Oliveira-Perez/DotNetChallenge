using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PicPayApiChallenge.Domain.Constants;
using PicPayApiChallenge.Domain.Contracts.Repositories;
using PicPayApiChallenge.Domain.Contracts.Services;
using PicPayApiChallenge.Domain.DTO;
using PicPayApiChallenge.Domain.Enums;
using PicPayApiChallenge.Domain.Exceptions.Transaction;
using PicPayApiChallenge.Domain.Models;
using static PicPayApiChallenge.Domain.Enums.Enums;

namespace PicPayApiChallenge.Domain.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ILogger<TransactionService> _logger;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private readonly ITransactionRepository _repository;
        private static string _authorizeTransactionMock;

        public TransactionService(ILogger<TransactionService> logger, IUserService commonUserService, IEmailService emailService, IOptions<ExternalUrls> options, ITransactionRepository repository)
        {
            _logger = logger;
            _userService = commonUserService;
            _emailService = emailService;
            _authorizeTransactionMock = options.Value.AuthorizeTransactionMock;
            _repository = repository;
        }

        public async Task SendPix(TransactionDTO dto)
        {
            var ( value, payer, payee ) = dto;

            await IsValidTransaction(payer, value);

            await IsAuthorizedTransaction();

            await ManageBalance(payer, payee, value);

            await CreateTransaction(payer, payee, value);

            await _emailService.SendEmailAsync(payee);
        }

        private async Task IsValidTransaction(Guid payerId, decimal value)
        {
            var payerType = await this._userService.GetUserType(payerId);

            if (payerType.Equals(UserType.Tradesman)) throw new InvalidTransactionException("A tradesman cannot send money to others.");

            if(!await this._userService.HasEnoughBalance(payerId, value)) throw new InvalidTransactionException("User don't have enough balance.");
        }

        private static async Task IsAuthorizedTransaction()
        {
            HttpClient _httpClient = new();

            var response = await _httpClient.GetAsync(_authorizeTransactionMock);

            if (!response.Content.ReadAsStringAsync().Result.Contains(AuthorizationResponse.Authorized))
            {
                throw new UnauthorizedTransactionException();
            }
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

        private async Task ManageBalance(Guid payer, Guid payee, decimal value)
        {
            await _userService.IncreaseBalance(payee, value);
            await _userService.DecreaseBalance(payer, value);
        }
    }
}
