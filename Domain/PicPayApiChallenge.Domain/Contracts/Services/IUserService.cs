using PicPayApiChallenge.Domain.Models;
using static PicPayApiChallenge.Domain.Enums.Enums;

namespace PicPayApiChallenge.Domain.Contracts.Services
{
    public interface IUserService
    {
        Task<bool> HasEnoughBalance(Guid id, decimal balance);
        Task<UserType?> GetUserType(Guid id);
        Task<UserEntity?> GetUserById(Guid id);
    }
}
