using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Interfaces;

namespace PicPayApiChallenge.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {

        private readonly SqlContext _sqlContext;

        public ClientRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
