namespace PicPayApiChallenge.Domain.DTO
{
    public class TransactionDTO
    {
        decimal Value { get; }
        Guid Payer { get; }
        Guid Payee { get; }

        public void Deconstruct(out decimal value, out Guid payer, out Guid payee)
        {
            value = this.Value;
            payer = this.Payer;
            payee = this.Payee;
        }
    }
}
