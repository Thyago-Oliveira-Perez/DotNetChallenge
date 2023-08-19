using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<TransactionEntity> Transactions { get; set; }
    }
}
