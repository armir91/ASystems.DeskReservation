using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Implementations;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using ASystems.DeskReservation.Web.Services.Interfaces;

namespace ASystems.DeskReservation.Web.Services.Implementations;

public class UserServices : IUserServices
{
    private readonly IUserRepository _userRepository;

    public UserServices(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    // GET ALL USERS
    public async Task<List<User>> GetAll()
    {
        var result = await _userRepository.GetAllAsync();
        return result;
    }

    public async Task<User> GetAsync(Guid id)
    {
        var result = await _userRepository.GetAsync(id);
        return result;
    }

    // CREATE USER
    public Task<User> Create(User user)
    {
        throw new NotImplementedException();
    }

    // EDIT USER
    public async Task<User> Edit(Guid id)
    {
        var result = await _userRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException("The user could not be found.");
        }
        return result;
    }

    public async Task<User> Edit(User user)
    {
        if (user == null)
        {
            throw new ArgumentException("There is no user");
        }
        return await _userRepository.Edit(user);
    }

    // USER DETAILS
    public Task<User> Details(Guid id)
    {
        throw new NotImplementedException();
    }

    // DELETE USER
    public Task<User> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
