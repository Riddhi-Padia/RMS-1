using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using PS.Domain.Data_Models;
using PS.Domain.View_Models;
using PS.Service.Interface;

namespace PS.Web.Controllers;

public class UsersController : Controller
{
    private readonly ILogger<UsersController> _logger;
    private readonly PizzaShopDbContext _context;

    private readonly IUserService _service ;

    public UsersController(ILogger<UsersController> logger, PizzaShopDbContext context, IUserService service)
    {
        _logger = logger;
        _context = context;
        _service = service;
    }

    public async IActionResult userList()
    {
        IEnumerable<UserDetails> userlist = await _service.getUserDetail();
        return View(userlist);
    }

    // get
    public IActionResult addUser()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult addUser(User u)
    {
        _context.Users.Add(u);//does not push the data into database
        _context.SaveChanges();//this command pushes the changes to the database
        return RedirectToAction("userList");
    }

    public IActionResult userProfile()
    {
        var u= from e in _context.Users
        orderby e.Id
        select e;
        Console.WriteLine("inside userprofile");
        Console.WriteLine(u);
        return View(u);
    }

    public IActionResult editUser()
    {
        return View();
    }
}
