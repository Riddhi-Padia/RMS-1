using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PS.Domain.Data_Models;
using PS.Domain.View_Models;
using PS.Service.Interface;

namespace PS.Web.Controllers;

public class UsersController : Controller
{
    private readonly ILogger<UsersController> _logger;
    private readonly PizzaShopDbContext _context;

    private readonly IUserService _service;

    //constructor
    public UsersController(ILogger<UsersController> logger, PizzaShopDbContext context, IUserService service)
    {
        _logger = logger;
        _context = context;
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> UserList()
    {
        IEnumerable<UserDetails> userlist = await _service.getUserDetail();
        return View(userlist);
        //return View( new _service.UserPagination() { userlist, Page = new() });
    }

    [HttpGet]
    // GET - Add user
    public IActionResult AddUser()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    // POST - add user
    public async Task<IActionResult> AddUser(UserProfile u)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid user data.");

        bool isAdded = await _service.AddUser(u);
        if (!isAdded)
            return Conflict("User with this email already exists.");

        return RedirectToAction("UserList");
    }

    public IActionResult UserProfile()
    {
        var u = from e in _context.Users
                orderby e.Id
                select e;
        return View(u);
    }

    [HttpGet]
    public async Task<IActionResult> EditUser(string email)
    {
        var user = await _service.GetUserProfilebyEmail(email);
        if (user == null)
            return NotFound("User not found.");

        return View(user);
    }

    [HttpPut]
    public async Task<IActionResult> EditUser(string email, UserProfile model)
    {
        if (!ModelState.IsValid)
            return BadRequest("Invalid user data.");

        bool isUpdated = await _service.EditUser(email, model);
        if (!isUpdated)
            return NotFound("User not found.");

        return Ok("User updated successfully!");
    }
}
