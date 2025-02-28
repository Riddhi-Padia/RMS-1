using PS.Service.Interface;
using PS.Domain.Data_Models;
using PS.Infrastructure.Implementation;
using PS.Domain.View_Models;
using System.Security.Cryptography;
using System.Text;

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

    public async Task<bool> AddUser(UserProfile u)
    {
        // Check if email already exists
        var existingUser = await _repository.GetUserByEmailAsync(u.Email);
        if (existingUser != null)
            return false; // Email already in use

        // Hash the password
        string hashedPassword = HashPassword(u.Password);

        // Map ViewModel to Entity
        var newUser = new PS.Domain.Data_Models.User
        {
            Firstname = u.Firstname,
            Lastname = u.Lastname,
            Username = u.Username,
            Email = u.Email,
            Phone = u.Phone,
            Profileimage = u.Profileimage,
            //add country, city, state
            Address = u.Address,
            RoleId = u.RoleID,
            Password = hashedPassword,
            Isactive = u.Isactive,
            IsDeleted = u.IsDeleted,
            IsFirstLogin = true,
            CreatedBy = 1,
            CreatedOn = DateTime.Now
        };

        await _repository.AddUserAsync(newUser);
        return true;
    }

    private string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    public async Task<bool> EditUser(string email, UserProfile u)
    {
        var user = await _repository.GetUserByEmailAsync(email);
        if (user == null)
            return false; // User not found

        user.Firstname = u.Firstname;
        user.Lastname = u.Lastname;
        user.Username = u.Username;
        user.Email = u.Email;
        user.Phone = u.Phone;
        user.Profileimage = u.Profileimage;
        //add country, city, state
        user.Address = u.Address;
        user.RoleId = u.RoleID;
        user.Isactive = u.Isactive;
        user.IsDeleted = u.IsDeleted;
        user.IsFirstLogin = true;
        user.ModifiedBy = 1;
        user.ModifiedOn = DateTime.Now;

        // Only update password if provided
        // if (!string.IsNullOrEmpty(model.Password))
        // {
        //     user.PasswordHash = HashPassword(model.Password);
        // }

        await _repository.UpdateUserAsync(user);
        return true;
    }

    public async Task<UserDetails> GetUserbyEmail(string email)
    {
        var user = await _repository.GetUserByIdAsync(email);
    if (user == null)
        return null;

    return new UserProfile
    {
        Firstname = user.Name,
        Lastname = user.Email,
        Email = user.Email,
        Phone = user.Phone,
        RoleId = user.RoleId,
        IsActive = user.IsActive
    };
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
