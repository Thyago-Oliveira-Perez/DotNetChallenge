using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Contracts.Repositories;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Repositories
{
    public class TrandesmanRepository : BaseRepository<TradesmanEntity>, ITradesmanRepository
    {
        public TrandesmanRepository(SqlContext sqlContext) : base(sqlContext) { }
    }
}
