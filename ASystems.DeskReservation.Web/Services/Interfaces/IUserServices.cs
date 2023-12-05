using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Models;

namespace ASystems.DeskReservation.Web.Services.Interfaces;

public interface IUserServices
{
    Task<List<User>> GetAll();
    Task<User> GetAsync(Guid id);
    Task<User> Edit(UserDto userDto);
    Task<User> Delete(Guid id);
    Task<User> Details(Guid id);
}
