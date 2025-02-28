using PS.Domain.View_Models;

namespace PS.Service.Interface;

public interface IUserService
{
    public Task<IEnumerable<UserDetails>> getUserDetail();

    public Task<bool> AddUser(UserProfile u);

    public Task<bool> EditUser(string email, UserProfile u);

    public Task<UserDetails> GetUserbyEmail(string email);
    // public Role getUserRole();

    // public Country getUserCountry();

    // public State getUserState();

    // public City getUserCity();
}
