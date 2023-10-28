using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Domain.Interfaces
{
    public interface IShopKeeperRepository
    {
        public Task<ShopKeeperEntity?> GetById(Guid id);
    }
}
