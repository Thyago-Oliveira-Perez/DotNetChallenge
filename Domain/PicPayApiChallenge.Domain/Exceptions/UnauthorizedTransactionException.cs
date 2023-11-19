namespace PicPayApiChallenge.Domain.Exceptions
{
    public class UnauthorizedTransactionException : Exception
    {
        public UnauthorizedTransactionException()
        {
        }

        public UnauthorizedTransactionException(string message) : base($"{Message}{message}") { }

        public static string Message => "Unauthorized transaction:";
    }
}
