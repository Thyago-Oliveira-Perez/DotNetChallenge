namespace PicPayApiChallenge.Domain.Models
{
    public class TransactionEntity : AbstractEntity
    {
        public decimal? amount { get; set; }
        public DateTime date { get; set; }
        public UserEntity Payer { get; set; }
        public Guid PayerId { get; set; }
        public UserEntity Payee { get; set; }
        public Guid PayeeId { get; set; }
    }
}
