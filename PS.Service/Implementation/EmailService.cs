using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Microsoft.Extensions.Options;
using PS.Service.Interface;
using PS.Domain.View_Models;

namespace PS.Services.Implementations
{
    public class EmailService : IEmailService
    {
        private readonly EmailData _emailSettings;

        public EmailService(IOptions<EmailData> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendResetPasswordEmailAsync(string toEmail, string resetLink)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.SenderEmail));
            email.To.Add(new MailboxAddress(toEmail, toEmail));
            email.Subject = "Password Reset";
            
            email.Body = new TextPart("html")
            {
                Text = $"<p>Click <a href='{resetLink}'>here</a> to reset your password.</p>"
            };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_emailSettings.SenderEmail, _emailSettings.Password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
