namespace PicPayApiChallenge.Domain.Models
{
    public class TransactionEntity : AbstractEntity
    {
        public decimal? amount { get; set; }
        public DateTime date { get; set; }
        public UserEntity Payer { get; set; }
        public UserEntity Payee { get; set; }
    }
}
