using PicPayApiChallenge.Domain.DTO;

namespace PicPayApiChallenge.Domain.Types
{
    public interface ITransferService
    {
        Task SendPix(TransactionDTO dto);
    }
}
