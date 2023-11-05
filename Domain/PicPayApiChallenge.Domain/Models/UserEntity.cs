using static PicPayApiChallenge.Domain.Enums.Enums;

namespace PicPayApiChallenge.Domain.Models
{
    public class UserEntity : AbstractEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public UserType Type { get; set; }
        public string? CPF { get; set; }
        public string? CNPJ { get; set; }
        public string Password { get; set; }

        public ICollection<TransactionEntity> Transactions { get; set; }
    }
}
