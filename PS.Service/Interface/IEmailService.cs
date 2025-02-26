namespace PS.Service.Interface;

public interface IEmailService
{
    Task SendResetPasswordEmailAsync(string toEmail, string resetLink);
}
