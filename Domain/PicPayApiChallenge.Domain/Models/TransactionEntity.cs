namespace PicPayApiChallenge.Domain.Models
{
    public class TransactionEntity : AbstractEntity
    {
        public decimal? Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid PayerId { get; set; }
        public Guid PayeeId { get; set; }
    }
}
