using PS.Domain.View_Models;
using PS.Domain.Data_Models;

namespace PS.Infrastructure.Interface;

public interface IUserRepository
{
    Task <IEnumerable<UserDetails>> GetAllUsersAsync();

    Task<User> AddUserAsync(User user);
    
    Task<User> GetUserByEmailAsync(string email);

    Task<User> UpdateUserAsync(User user);
}
