using PicPayApiChallenge.Domain.DTO;

namespace PicPayApiChallenge.Domain.Interfaces
{
    public interface ITransactionService
    {
        Task SendPix(TransactionDTO dto);
    }
}
