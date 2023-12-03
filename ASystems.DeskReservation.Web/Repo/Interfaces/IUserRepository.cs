using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Repo.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task<User> GetAsync(Guid id);
    Task<User> Edit(Guid id);
    Task<User> Edit(User user);
    Task<User> Delete(Guid id);
    Task<User> Details(Guid id);
}
