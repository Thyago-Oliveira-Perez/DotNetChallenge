using Microsoft.EntityFrameworkCore;
using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Contracts.Repositories;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(SqlContext sqlContext) : base(sqlContext) { }

        public async Task<bool> HasBalance(Guid id, decimal value)
        {
            var user = await this._dbSet.FirstOrDefaultAsync((c) => c.Id.Equals(id));
            return user?.Balance >= value;
        }
    }
}
