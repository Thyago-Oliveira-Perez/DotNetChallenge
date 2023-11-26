using Microsoft.Extensions.Options;
using PicPayApiChallenge.Domain.Constants;
using PicPayApiChallenge.Domain.Contracts.Services;
using PicPayApiChallenge.Domain.Exceptions.Email;

namespace PicPayApiChallenge.Domain.Services
{
    public class EmailService : IEmailService
    {
        private readonly IUserService _userService;
        private static string _emailServiceMock;

        public EmailService(IOptions<ExternalUrls> options, IUserService userService)
        {
            _emailServiceMock = options.Value.EmailServiceMock;
            _userService = userService;
        }

        public async Task SendEmailAsync(Guid receiverId)
        {
            var receiver = await _userService.GetUserById(receiverId);

            await SendEmail(receiver.Email);
        }

        private async Task SendEmail(string email)
        {
            HttpClient _httpClient = new();

            var response = await _httpClient.GetAsync(_emailServiceMock);

            if (!response.Content.ReadAsStringAsync().Result.Contains(EmailServiceResponse.Sent))
            {
                throw new UnableToSendEmailException("Unable to send email!");
            }
        }
    }
}
