using static PicPayApiChallenge.Domain.Models.Enums;

namespace PicPayApiChallenge.Domain.Models
{
    public class UserEntity : AbstractEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public ICollection<TransactionEntity> Transactions { get; set; }
    }
}
