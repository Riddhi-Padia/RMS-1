using PS.Service.Interface;
using PS.Domain.Data_Models;
using PS.Infrastructure.Implementation;
using PS.Domain.View_Models;

namespace PS.Service.Implementation;

public class UserService : IUserService
{
    private readonly UserRepository _repository;

    public UserService(UserRepository repository)
    {
        _repository = repository;
    }
    public Task<IEnumerable<UserDetails>> getUserDetail()
    {
        return _repository.GetAllUsersAsync();
    }

    // public Role getUserRole()
    // {

    // }

    // public Country getUserCountry()
    // {

    // }

    // public State getUserState()
    // {

    // }

    // public City getUserCity()
    // {

    // }
}
