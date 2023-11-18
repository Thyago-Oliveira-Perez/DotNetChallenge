using PicPayApiChallenge.Domain.Contracts.Repositories;
using PicPayApiChallenge.Domain.Contracts.Services;

namespace PicPayApiChallenge.Domain.Services
{
    public class CommonUserService : ICommonUserService
    {
        private readonly ICommonUserRepository _repository;

        public CommonUserService(ICommonUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> HasEnoughBalance(Guid id, decimal value)
        {
           return await this._repository.HasBalance(id, value);
        }
    }
}
