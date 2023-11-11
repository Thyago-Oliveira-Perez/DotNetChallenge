using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Domain.Interfaces
{
    public interface ICommonUserRepository : IRepository<CommonUserEntity>
    {
        Task<bool> HasBalance(Guid id, decimal value);
    }
}
