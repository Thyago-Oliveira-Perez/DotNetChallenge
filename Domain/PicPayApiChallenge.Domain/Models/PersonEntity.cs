using static PicPayApiChallenge.Domain.Models.Enums;

namespace PicPayApiChallenge.Domain.Models
{
    public abstract class PersonEntity : AbstractEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public string Password { get; set; }
    }
}
