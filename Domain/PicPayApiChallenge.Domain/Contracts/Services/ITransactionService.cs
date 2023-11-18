using PicPayApiChallenge.Domain.DTO;

namespace PicPayApiChallenge.Domain.Contracts.Services
{
    public interface ITransactionService
    {
        Task SendPix(TransactionDTO dto);
    }
}
