using PS.Domain.View_Models;

namespace PS.Infrastructure.Interface;

public interface IUserRepository
{
    Task <IEnumerable<UserDetails>> GetAllUsersAsync();
}
