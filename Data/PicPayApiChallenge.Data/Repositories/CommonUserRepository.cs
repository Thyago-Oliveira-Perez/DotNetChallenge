using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Interfaces;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Repositories
{
    public class CommonUserRepository : BaseRepository<CommonUserEntity>, ICommonUserRepository
    {
        public CommonUserRepository(SqlContext sqlContext) : base(sqlContext) { }
    }
}
