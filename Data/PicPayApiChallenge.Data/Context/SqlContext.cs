using Microsoft.EntityFrameworkCore;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
            base.OnModelCreating(model);
        }

        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<ShopKeeperEntity> ShopKeepers { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }
    }
}
