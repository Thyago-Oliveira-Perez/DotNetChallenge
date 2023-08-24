namespace PicPayApiChallenge.Domain.Models
{
    public class ClientEntity : PersonEntity
    {
        public ICollection<TransactionEntity> Transactions { get; set; }
    }
}
