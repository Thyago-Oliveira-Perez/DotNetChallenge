namespace PicPayApiChallenge.Domain.Contracts.Services
{
    public interface ICommonUserService
    {
        Task<bool> HasEnoughBalance(Guid id, decimal balance);
    }
}
