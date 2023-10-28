using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Domain.Interfaces
{
    public interface IClientRepository
    {
        public Task<ClientEntity?> GetById(Guid id);
    }
}
