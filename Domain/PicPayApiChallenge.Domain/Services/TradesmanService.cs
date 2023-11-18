using PicPayApiChallenge.Domain.Contracts.Repositories;
using PicPayApiChallenge.Domain.Contracts.Services;

namespace PicPayApiChallenge.Domain.Services
{
    public class TradesmanService : ITradesmanService
    {
        private readonly ITradesmanRepository _repository;

        public TradesmanService(ITradesmanRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Exists(Guid id)
        {
            return await this._repository.Exists(id);
        }
    }
}
