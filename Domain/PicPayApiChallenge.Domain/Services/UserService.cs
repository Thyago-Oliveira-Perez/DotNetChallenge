using PicPayApiChallenge.Domain.Contracts.Repositories;
using PicPayApiChallenge.Domain.Contracts.Services;

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

        public async Task<bool> Exists(Guid id)
        {
            return await this._repository.Exists(id);
        }
    }
}
