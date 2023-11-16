using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Repo.Interfaces;

public interface IDeskRepository
{
    Task<List<Desk>> GetAllAsync();
    Task<Desk> GetAsync(Guid id);
    Task<Desk> Create(Desk desk);
    Task<Desk> Edit(Guid id);
    Task<Desk> Edit(Desk desk);
    Task<Desk> Delete(Guid id);
    Task<Desk> Details(Guid id);
}
