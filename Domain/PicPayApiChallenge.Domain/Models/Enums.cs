namespace PicPayApiChallenge.Domain.Models
{
    public class Enums
    {
        public enum KeyType
        {
            Email = 1,
            Cpf = 2,
            RandomKey = 3,
            Phone = 4
        }

        public enum UserType
        {
            Client = 1,
            ShopKeeper = 2
        }
    }
}
