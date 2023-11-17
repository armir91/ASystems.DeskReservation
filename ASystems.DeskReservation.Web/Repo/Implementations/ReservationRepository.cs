using ASystems.DeskReservation.Web.Data.Context;
using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ASystems.DeskReservation.Web.Repo.Implementations;

public class ReservationRepository : IReservationRepository
{
    private readonly ApplicationDbContext _context;

    public ReservationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET ALL: Reservations
    public async Task<List<Reservation>> GetAllAsync()
    {
        var result = await _context.Reservations
            .Include(r => r.Desk)
            .Include(r => r.User).ToListAsync();

        return result;
    }

    public async Task<Reservation> GetAsync(Guid id)
    {
        var result = await _context.Reservations
                .Include(r => r.Desk)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
        return result;
    }

    // CREATE: Reservation
    public async Task<Reservation> Create(Reservation reservation)
    {
        await _context.Reservations.AddAsync(reservation);
        await _context.SaveChangesAsync();
        return reservation;
    }

    // EDIT: Reservation
    public async Task<Reservation> Edit(Guid id)
    {
        var result = await _context.Reservations.FindAsync(id);
        if (result == null)
        {
            throw new ArgumentException("There is no reservation found");
        }
        return result;
    }


    public async Task<Reservation> Edit(Reservation reservation)
    {
        if (reservation == null)
        {
            throw new ArgumentException("There is no reservation");
        }
        _context.Reservations.Update(reservation);
        await _context.SaveChangesAsync();

        return reservation;
    }

    // GET: Reservation details
    public Task<Reservation> Details(Guid id)
    {
        throw new NotImplementedException();
    }

    // DELETE: Reservation
    public Task<Reservation> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
