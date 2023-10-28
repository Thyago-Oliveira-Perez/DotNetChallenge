namespace PicPayApiChallenge.Domain.DTO
{
    public class TransactionDTO
    {
        decimal value { get; }
        Guid payer { get; }
        Guid payee { get; }
    }
}
