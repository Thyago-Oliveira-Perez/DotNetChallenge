using Microsoft.EntityFrameworkCore;
using PicPayApiChallenge.Data.Context;
using PicPayApiChallenge.Domain.Interfaces;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {

        private readonly SqlContext _sqlContext;

        public ClientRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<ClientEntity?> GetById(Guid id) => await _sqlContext.Clients.SingleOrDefaultAsync(x => x.Id == id);
    }
}
