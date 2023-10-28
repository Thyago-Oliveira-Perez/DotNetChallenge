using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Interfaces;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Repositories
{
    public class ShopKeeperRepository : BaseRepository<ShopKeeperEntity>, IShopKeeperRepository
    {
        public ShopKeeperRepository(SqlContext sqlContext) : base(sqlContext) { }
    }
}
