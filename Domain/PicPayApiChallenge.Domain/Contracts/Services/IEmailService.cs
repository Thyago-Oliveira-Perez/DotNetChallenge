namespace PicPayApiChallenge.Domain.Contracts.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(Guid receiverId);
    }
}
