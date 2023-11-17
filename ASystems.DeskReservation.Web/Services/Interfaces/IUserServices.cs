using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Services.Interfaces;

public interface IUserServices
{
    Task<List<User>> GetAll();
    Task<User> Create(User user);
    Task<User> GetAsync(Guid id);
    Task<User> Edit(Guid id);
    Task<User> Edit(User user);
    Task<User> Delete(Guid id);
    Task<User> Details(Guid id);
}
