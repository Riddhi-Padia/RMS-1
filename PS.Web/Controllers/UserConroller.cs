using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PS.Service.Interface;
using PS.Web.Models;

namespace PS.Web.Controllers;

public class UserController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEmailService _emailService;

    public UserController(ILogger<HomeController> logger, IEmailService emailService)
    {
        _logger = logger;
        _emailService = emailService;
    }

    public async Task<IActionResult> CreateUser(string email)
        {
            // Assume user creation happens here and we generate a reset token
            string resetToken = "generated-reset-token";
            string resetLink = Url.Link("default", new { Controller = "Home", Action = "resetPassword", token = resetToken, email });
//            string resetLink = Url.Action("ResetPassword", "Home", new { token = resetToken, email }, Request.Scheme);
            await _emailService.SendResetPasswordEmailAsync(email, resetLink);

            return Ok("User created and reset password email sent!");
        }
}
