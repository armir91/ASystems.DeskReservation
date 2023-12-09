using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Repo.Interfaces;

public interface IReservationRepository
{
    Task<List<Reservation>> GetAllAsync(string searchPhrase);
    Task<Reservation> GetAsync(Guid id);
    Task<Reservation> Create(Reservation reservation);
    Task<Reservation> Edit(Reservation reservation);
    Task<Reservation> Delete(Guid id);
    Task<Reservation> Details(Guid id);
    Task<List<Reservation>> GetUserReservations(Guid userId, DateTime startDate, DateTime endDate);
}
