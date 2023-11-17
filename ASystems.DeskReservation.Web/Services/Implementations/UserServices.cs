using ASystems.DeskReservation.Web.Data.Entities;
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

    public Task<User> Create(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> Details(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> Edit(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> Edit(User user)
    {
        throw new NotImplementedException();
    }

    // GET ALL USERS
    public async Task<List<User>> GetAll()
    {
        var result = await _userRepository.GetAllAsync();
        return result;
    }

    public Task<User> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
