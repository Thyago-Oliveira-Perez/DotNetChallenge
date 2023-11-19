namespace PicPayApiChallenge.Domain.Contracts.Services
{
    public interface IUserService
    {
        Task<bool> HasEnoughBalance(Guid id, decimal balance);
        Task<bool> Exists(Guid id);
    }
}
