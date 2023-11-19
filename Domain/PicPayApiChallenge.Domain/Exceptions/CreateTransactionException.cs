namespace PicPayApiChallenge.Domain.Exceptions
{
    public class CreateTransactionException : Exception
    {
        public CreateTransactionException(string message) : base($"{Message}{message}") { }

        public static string Message => "Create transaction:";
    }
}
