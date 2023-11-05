namespace PicPayApiChallenge.Domain.Enums
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
            client = 1,
            shopkeeper = 2,
        }
    }
}
