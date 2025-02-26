using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PS.Web.Models;

namespace PS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult forgotPassword()
    {
        return View();
    }

    public IActionResult changePassword()
    {
        return View();
    }

    public IActionResult adminDashboard()
    {
        return View();
    }

    public IActionResult Demo()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
