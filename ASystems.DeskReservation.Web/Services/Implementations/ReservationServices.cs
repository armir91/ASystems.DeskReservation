using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Implementations;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using ASystems.DeskReservation.Web.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ASystems.DeskReservation.Web.Services.Implementations;

public class ReservationServices : IReservationServices
{
    private readonly IReservationRepository _reservationRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ReservationServices(IReservationRepository reservationRepository, IHttpContextAccessor httpContextAccessor)
    {
        _reservationRepository = reservationRepository;
        _httpContextAccessor = httpContextAccessor;
    }

    // GET ALL RESERVATIONS
    public async Task<List<Reservation>> GetAll(string searchPhrase)
    {
        try
        {
            var currentLoggedInUserId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _reservationRepository.GetAllAsync(searchPhrase);

            if (_httpContextAccessor.HttpContext.User.IsInRole("Admin"))
            {
                return result;
            }
            var loggedInUserData = result.Where(x => x.UserId.ToString() == currentLoggedInUserId).ToList();

            return loggedInUserData;
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

    public async Task<List<Reservation>> GetUserReservations(Guid userId, DateTime startDate, DateTime endDate)
    {
        try
        {
            var result = await _reservationRepository.GetUserReservations(userId, startDate, endDate);
            return result;
        }
        catch (Exception)
        {
            throw new ArgumentException("No reservations found.");
        }
    }
}
