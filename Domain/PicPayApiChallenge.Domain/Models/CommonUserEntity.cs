namespace PicPayApiChallenge.Domain.Models
{
    public class CommonUserEntity : UserEntity
    {
        public IEnumerable<TransactionEntity> Transactions { get; set; }
    }
}
