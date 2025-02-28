using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using PS.Domain.Data_Models;
using PS.Domain.View_Models;
using PS.Infrastructure.Interface;

namespace PS.Infrastructure.Implementation;

public class UserRepository : IUserRepository
{
    private readonly PizzaShopDbContext _context;

    public UserRepository(PizzaShopDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UserDetails>> GetAllUsersAsync()
    {
        IQueryable<User> users = _context.Users.Include(r => r.Role);

        return await users.Select(u => new UserDetails
        {
            Email = u.Email,
            Role = u.Role.Name,
            Firstname = u.Firstname,
            Lastname = u.Lastname,
            Username = u.Username,
            Phone = u.Phone,
            Profileimage = u.Profileimage,
            Isactive = (bool)u.Isactive,
            IsDeleted = (bool)u.IsDeleted
        })
            .ToListAsync();
    }

    public async Task<User> AddUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<Role> GetUserRoleAsync(int id)
    {
        return await _context.Roles.FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }
}