namespace PicPayApiChallenge.Domain.Models
{
    public abstract class UserEntity : AbstractEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public string Password { get; set; }
    }
}
