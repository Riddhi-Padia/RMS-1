using PS.Domain.View_Models;

namespace PS.Service.Interface;

public interface IUserService
{
    public Task<IEnumerable<UserDetails>> getUserDetail();

    // public Role getUserRole();

    // public Country getUserCountry();

    // public State getUserState();

    // public City getUserCity();
}
