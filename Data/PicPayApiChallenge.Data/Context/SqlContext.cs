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

        public DbSet<CommonUserEntity> CommonUsers { get; set; }
        public DbSet<TradesmanEntity> Tradesman { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }
    }
}
