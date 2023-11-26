using PicPayApiChallenge.Domain.Contracts.Repositories;
using PicPayApiChallenge.Domain.Contracts.Services;
using PicPayApiChallenge.Domain.Models;
using static PicPayApiChallenge.Domain.Enums.Enums;

namespace PicPayApiChallenge.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> HasEnoughBalance(Guid id, decimal value)
        {
           return await this._repository.HasBalance(id, value);
        }

        public async Task<UserType?> GetUserType(Guid id)
        {
            return (await this._repository.GetById(id))?.Type;
        }

        public async Task<UserEntity?> GetUserById(Guid id)
        {
            return await this._repository.GetById(id);
        }
    }
}
