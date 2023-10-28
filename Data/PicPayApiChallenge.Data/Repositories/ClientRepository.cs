using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Interfaces;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Repositories
{
    public class ClientRepository : BaseRepository<ClientEntity>, IClientRepository
    {
        public ClientRepository(SqlContext sqlContext) : base(sqlContext) { }
    }
}
