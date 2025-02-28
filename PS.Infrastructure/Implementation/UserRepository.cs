using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using PS.Domain.Data_Models;
using PS.Domain.View_Models;
using PS.Infrastructure.Interface;

namespace PS.Infrastructure.Implementation;

public class UserRepository: IUserRepository
{
       private readonly PizzaShopDbContext _context;

       public UserRepository(PizzaShopDbContext context)
       {
        _context = context;
       }

       public async Task<IEnumerable<UserDetails>> GetAllUsersAsync()
       {
            var users = _context.Users.Include(r => _context.Roles).AsQueryable();
            
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
}