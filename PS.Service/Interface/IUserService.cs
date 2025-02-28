using PS.Domain.View_Models;

namespace PS.Service.Interface;

public interface IUserService
{
    public Task<IEnumerable<UserDetails>> getUserDetail();

    public Task<bool> AddUser(UserProfile u);

    public Task<bool> EditUser(string email, UserProfile u);

    public Task<UserProfile> GetUserProfilebyEmail(string email);
}
