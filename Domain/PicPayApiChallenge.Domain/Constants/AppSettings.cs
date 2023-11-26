namespace PicPayApiChallenge.Domain.Constants
{
    public class LogLevel
    {
        public string Default { get; set; }
        public string Warning { get; set; }
        public string Error { get; set; }
    }

    public class Logging
    {
        public LogLevel LogLevel { get; set; }
    }

    public class ExternalUrls 
    {
        public string AuthorizeTransactionMock { get; set; }
        public string EmailServiceMock { get; set; }
    }

    public class ConnectionStrings
    {
        public string DatabaseConnection { get; set; }
    }

    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public ExternalUrls ExternalUrls { get; set; }
        public Logging Logging { get; set; }
        public string AllowedHosts { get; set; }
    }
}
