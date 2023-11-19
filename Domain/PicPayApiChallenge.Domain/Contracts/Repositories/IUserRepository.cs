using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Domain.Contracts.Repositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<bool> HasBalance(Guid id, decimal value);
    }
}
