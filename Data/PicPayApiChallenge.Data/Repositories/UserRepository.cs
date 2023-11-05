using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Interfaces;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(SqlContext sqlContext) : base(sqlContext) { }
    }
}
