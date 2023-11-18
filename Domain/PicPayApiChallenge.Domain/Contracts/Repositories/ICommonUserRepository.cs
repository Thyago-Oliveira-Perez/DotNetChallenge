using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Domain.Contracts.Repositories
{
    public interface ICommonUserRepository : IRepository<CommonUserEntity>
    {
        Task<bool> HasBalance(Guid id, decimal value);
    }
}
