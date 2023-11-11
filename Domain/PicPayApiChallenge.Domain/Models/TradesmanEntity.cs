namespace PicPayApiChallenge.Domain.Models
{
    public class TradesmanEntity : UserEntity
    {
        public string? CNPJ { get; set; }
        public IEnumerable<TransactionEntity> Transactions { get; set; }
    }
}
