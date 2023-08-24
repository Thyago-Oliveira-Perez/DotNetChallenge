using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PicPayApiChallenge.Domain.Models;

namespace PicPayApiChallenge.Data.Mapping
{
    public class ClientMapping : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(50)").HasColumnType("unique");
            builder.Property(x => x.CPF).IsRequired().HasColumnType("varchar(11)").HasColumnType("unique");
            builder.Property(x => x.Password).IsRequired().HasColumnType("varchar(50)");

            builder.ToTable("clients");
        }
    }
}
