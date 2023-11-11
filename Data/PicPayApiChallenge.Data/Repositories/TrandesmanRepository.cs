using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Interfaces;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Repositories
{
    public class TrandesmanRepository : BaseRepository<TradesmanEntity>, ITradesmanRepository
    {
        public TrandesmanRepository(SqlContext sqlContext) : base(sqlContext) { }
    }
}
