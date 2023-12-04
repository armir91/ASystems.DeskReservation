using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Repo.Interfaces;

public interface IRoleRepository
{
    Task<List<Role>> GetAllAsync();
    Task<Role> GetAsync(Guid id);
    Task<Role> Create(Role role);
    Task<Role> Edit(Guid roleId, string roleName);
    Task<Role> Delete(Guid id);
    Task<Role> Details(Guid id);
}
