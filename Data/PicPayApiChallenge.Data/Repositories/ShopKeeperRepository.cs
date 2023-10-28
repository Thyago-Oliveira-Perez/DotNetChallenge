using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Interfaces;

namespace PicPayApiChallenge.Data.Repositories
{
    public class ShopKeeperRepository : IShopKeeperRepository
    {

        private readonly SqlContext _sqlContext;

        public ShopKeeperRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
