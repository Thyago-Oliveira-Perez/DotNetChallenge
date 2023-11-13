using System.ComponentModel.DataAnnotations;

namespace PicPayApiChallenge.Domain.DTO
{
    public class TransactionDTO
    {
        [Required]
        public decimal Value { get; set; }
        [Required]
        public Guid Payer { get; set; }
        [Required]
        public Guid Payee { get; set; }

        public void Deconstruct(out decimal value, out Guid payer, out Guid payee)
        {
            value = this.Value;
            payer = this.Payer;
            payee = this.Payee;
        }
    }
}
