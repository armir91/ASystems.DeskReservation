using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Implementations;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using ASystems.DeskReservation.Web.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ASystems.DeskReservation.Web.Services.Implementations;

public class UserServices : IUserServices
{
    private readonly IUserRepository _userRepository;
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;

    public UserServices(IUserRepository userRepository, UserManager<User> userManager, RoleManager<Role> roleManager)
    {
        _userRepository = userRepository;
        _userManager = userManager;
        _roleManager = roleManager;
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

    public async Task<User> Edit(UserDto userDto)
    {
        var userToEdit = await _userManager.FindByIdAsync(userDto.Id.ToString());
        if (userToEdit == null)
        {
            throw new ArgumentException("There is no user");
        }

        var roles = await _userManager.GetRolesAsync(userToEdit);
        await _userManager.RemoveFromRolesAsync(userToEdit, roles.ToArray());
        await _userManager.AddToRoleAsync(userToEdit, userDto.RoleName);

        

        return await _userRepository.Edit(userToEdit);
    }

    // USER DETAILS
    public async Task<User> Details(Guid id)
    {
        var result = await _userRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException("No User details found.");
        }
        return await _userRepository.Details(id);
    }

    // DELETE USER
    public async Task<User> Delete(Guid id)
    {
        var result = await _userRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException($"The User with the ID: {id} could not be found.");
        }
        return await _userRepository.Delete(id);
    }

    public Task<User> Edit(User user)
    {
        throw new NotImplementedException();
    }
}

public class UserDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string RoleName { get; set; }
}
