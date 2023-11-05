namespace PicPayApiChallenge.Domain.Models
{
    public class TransactionEntity : AbstractEntity
    {
        public decimal? Amount { get; set; }
        public DateTime Date { get; set; }
        public UserEntity Client { get; set; }
        public Guid ClientId { get; set; }
        public UserEntity Shopkeeper { get; set; }
        public Guid ShopkeeperId { get; set; }
    }
}
