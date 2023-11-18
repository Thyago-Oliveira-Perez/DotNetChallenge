namespace PicPayApiChallenge.Domain.Contracts.Services
{
    public interface ITradesmanService
    {
        Task<bool> Exists(Guid id);
    }
}
