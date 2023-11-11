namespace PicPayApiChallenge.Domain.Models
{
    public class TransactionEntity : AbstractEntity
    {
        public decimal? Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid CommonUserId { get; set; }
        public Guid TradesmanId { get; set; }
    
        public virtual CommonUserEntity CommonUser { get; set; }
        public virtual TradesmanEntity Tradesman { get; set; }
    }
}
