using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Models;
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
        var userToEdit = await _userRepository.GetAsync(userDto.Id);


        if (userToEdit == null)
        {
            throw new ArgumentException("There is no user");
        }

        var roles = await _userManager.GetRolesAsync(userToEdit);
        await _userManager.RemoveFromRolesAsync(userToEdit, roles.ToArray());
        await _userManager.AddToRoleAsync(userToEdit, userDto.RoleName);

        userToEdit.FirstName = userDto.FirstName;
        userToEdit.LastName = userDto.LastName;
        userToEdit.Email = userDto.Email;
        userToEdit.PhoneNumber = userDto.PhoneNumber;
        userToEdit.CheckedIn = userDto.CheckedIn;
        

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
}
