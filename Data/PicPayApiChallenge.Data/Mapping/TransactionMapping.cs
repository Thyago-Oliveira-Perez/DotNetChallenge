using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Mapping
{
    public class TransactionMapping : IEntityTypeConfiguration<TransactionEntity>
    {
        public void Configure(EntityTypeBuilder<TransactionEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.amount).IsRequired().HasColumnType("decimal");
            builder.Property(x => x.date).IsRequired().HasColumnType("date");
            builder.HasOne(x => x.Payer).WithMany(x => x.Transactions).IsRequired();
            builder.Property(x => x.PayerId).IsRequired();
            builder.HasOne(x => x.Payee).WithMany(x => x.Transactions).IsRequired();
            builder.Property(x => x.PayeeId).IsRequired();

            builder.ToTable("transactions");
        }
    }
}
