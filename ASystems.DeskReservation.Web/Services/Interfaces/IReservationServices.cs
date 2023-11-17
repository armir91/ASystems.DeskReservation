using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Services.Interfaces;

public interface IReservationServices
{
    Task<List<Reservation>> GetAll();
    Task<Reservation> GetAsync(Guid id);
    Task<Reservation> Create(Reservation reservation);
    Task<Reservation> Edit(Guid id);
    Task<Reservation> Edit(Reservation reservation);
    Task<Reservation> Delete(Guid id);
    Task<Reservation> Details(Guid id);
}
