using Microsoft.EntityFrameworkCore;
using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Interfaces;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Repositories
{
    public class ShopKeeperRepository : IShopKeeperRepository
    {

        private readonly SqlContext _sqlContext;

        public ShopKeeperRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<ShopKeeperEntity?> GetById(Guid id) => await _sqlContext.ShopKeepers.SingleOrDefaultAsync(x => x.Id == id);
    }
}
