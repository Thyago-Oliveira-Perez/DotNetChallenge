namespace PicPayApiChallenge.Domain.Models
{
    public class ShopKeeperEntity : PersonEntity
    {
        public Guid ShopId { get; set; }
        public ICollection<TransactionEntity> Transactions { get; set; }
    }
}
