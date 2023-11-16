using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Services.Interfaces;

public interface IDeskServices
{
    Task<List<Desk>> GetAll();
    Task<Desk> Create(Desk desk);
    Task<Desk> GetAsync(Guid id);
    Task<Desk> Edit(Guid id);
    Task<Desk> Edit(Desk desk);
    Task<Desk> Delete(Guid id);
    Task<Desk> Details(Guid id);
}
