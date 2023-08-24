using Microsoft.EntityFrameworkCore;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
            base.OnModelCreating(model);
        }

        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<ShopKeeperEntity> ShopKeepers { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }
    }
}
