namespace PicPayApiChallenge.Domain.Models
{
    public class TransactionEntity : AbstractEntity
    {
        public decimal? Amount { get; set; }
        public DateTime Date { get; set; }
        public ClientEntity Client { get; set; }
        public Guid ClientId { get; set; }
        public ShopKeeperEntity Shopkeeper { get; set; }
        public Guid ShopkeeperId { get; set; }
    }
}
