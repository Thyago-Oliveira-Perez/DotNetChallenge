namespace PicPayApiChallenge.Domain.Exceptions.Email
{
    public class UnableToSendEmailException : Exception
    {
        public UnableToSendEmailException(string message) : base($"{Message}{message}") { }

        public static string Message => "Sending email:";
    }
}
