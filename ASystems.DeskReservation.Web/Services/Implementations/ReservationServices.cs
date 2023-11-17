using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using ASystems.DeskReservation.Web.Services.Interfaces;

namespace ASystems.DeskReservation.Web.Services.Implementations;

public class ReservationServices : IReservationServices
{
    private readonly IReservationRepository _reservationRepository;

    public ReservationServices(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }

    // CREATE Reservation
    public async Task<Reservation> Create(Reservation reservation)
    {
        var result = await _reservationRepository.Create(reservation);
  
        return result;
    }

    // DELETE RESERVATION
    public Task<Reservation> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    // GET RESERVATION DETAILS
    public Task<Reservation> Details(Guid id)
    {
        throw new NotImplementedException();
    }

    // EDIT RESERVATION
    public Task<Reservation> Edit(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> Edit(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    // GET ALL RESERVATIONS
    public async Task<List<Reservation>> GetAll()
    {
        var result = await _reservationRepository.GetAllAsync();
        return result;
    }

    public Task<Reservation> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
