using ASystems.DeskReservation.Web.Data.Context;
using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ASystems.DeskReservation.Web.Repo.Implementations;

public class ReservationRepository : IReservationRepository
{
    private readonly ApplicationDbContext _context;


    public ReservationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET ALL: Reservations
    public async Task<List<Reservation>> GetAllAsync(string searchPhrase)
    {
        try
        {
            var result = await _context.Reservations
                .Include(x => x.Desk)
                .Include(x => x.User)
                .OrderBy(x => x.ReservedTime)
                .ToListAsync();

            if (!string.IsNullOrEmpty(searchPhrase))
            {
                result = result
                    .Where(r => r.User.FirstName
                    .Contains(searchPhrase, System.StringComparison.CurrentCultureIgnoreCase) || r.Desk.Name.Contains(searchPhrase, System.StringComparison.CurrentCultureIgnoreCase))
                .ToList();
            }

            return result;
        }
        catch (Exception)
        {
            throw new ArgumentException("Reservation data could not be retrieved.");
        }
    }

    public async Task<Reservation> GetAsync(Guid id)
    {
        try
        {
            var result = await _context.Reservations
                .Include(x => x.Desk)
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }
        catch (Exception)
        {
            throw new ArgumentException($"The reservation with ID: {id} could not be retrieved.");
        }
    }

    // CREATE: Reservation
    public async Task<Reservation> Create(Reservation reservation)
    {
        try
        {
            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();

            return reservation;
        }
        catch (Exception)
        {
            throw new ArgumentException("The reservation could not be created.");
        } 
    }

    // EDIT: Reservation
    public async Task<Reservation> Edit(Reservation reservation)
    {
        if (reservation == null)
        {
            throw new ArgumentException("No reservation found.");
        }
        _context.Reservations.Update(reservation);
        await _context.SaveChangesAsync();

        return reservation;
    }

    // GET: Reservation details
    public async Task<Reservation> Details(Guid id)
    {
        var result = await _context.Reservations.Where((x => x.Id == id)).FirstOrDefaultAsync();
        if (result == null)
        {
            throw new ArgumentException("The reservation returned no results.");
        }
        return result;
    }

    // DELETE: Reservation
    public async Task<Reservation> Delete(Guid id)
    {
        var result = await _context.Reservations.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
        {
            throw new ArgumentException("The desk returned no results.");
        }
        _context.Reservations.Remove(result);
        await _context.SaveChangesAsync();

        return result;
    }

    public async Task<List<Reservation>> GetUserReservations(Guid userId, DateTime startDate, DateTime endDate)
    {
        var result = await _context.Reservations
            .Where(r => r.UserId == userId && r.StartDate <= endDate && startDate <= r.EndDate)
            .ToListAsync();

        return result;
    }
}
