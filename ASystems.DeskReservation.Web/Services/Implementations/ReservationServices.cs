using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Implementations;
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

    // GET ALL RESERVATIONS
    public async Task<List<Reservation>> GetAll()
    {
        try
        {
            var result = await _reservationRepository.GetAllAsync();
            return result;
        }
        catch (Exception)
        {

            throw new ArgumentException("No reservations found.");
        }
    }

    public async Task<Reservation> GetAsync(Guid id)
    {
        try
        {
            var result = await _reservationRepository.GetAsync(id);
            return result;
        }
        catch (Exception)
        {

            throw new ArgumentException($"The reservation with ID: {id} could not be retrieved.");
        }
    }

    // CREATE Reservation
    public async Task<Reservation> Create(Reservation reservation)
    {
        try
        {
            var result = await _reservationRepository.Create(reservation);
            return result;
        }
        catch (Exception)
        {

            throw new ArgumentException("The reservation could not be created.");
        }
    }

    // EDIT RESERVATION
    public async Task<Reservation> Edit(Guid id)
    {
        var result = await _reservationRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException("The reservation could not be found.");
        }

        return result;
    }

    public async Task<Reservation> Edit(Reservation reservation)
    {
        if (reservation == null)
        {
            throw new ArgumentException("There is no reservation");
        }
        return await _reservationRepository.Edit(reservation);
    }

    // GET RESERVATION DETAILS
    public async Task<Reservation> Details(Guid id)
    {
        var result = await _reservationRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException("The reservation details could not be found.");
        }
        return await _reservationRepository.Details(id);
    }

    // DELETE RESERVATION
    public async Task<Reservation> Delete(Guid id)
    {
        var result = await _reservationRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException($"The reservation with the ID: {id} could not be found.");
        }
        return await _reservationRepository.Delete(id);
    }
}
