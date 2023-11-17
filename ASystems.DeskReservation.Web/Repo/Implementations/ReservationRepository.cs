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

    // CREATE: Reservation
    public async Task<Reservation> Create(Reservation reservation)
    {
        /*await _context.Reservations.*/

        /*.Include(x => x.User.Id)
        .Include(x => x.Desk.Id)
        .ToListAsync();*/
        /*await _context.Reservations.AddAsync(reservation);*/

        var result = new Reservation()
        {
            Id = Guid.NewGuid(),
            UserId = reservation.User.Id,
            DeskId = reservation.User.Id
            ReservedTime = DateTime.Now
        };

        await _context.Reservations.AddAsync(result);
        await _context.SaveChangesAsync();

        return reservation;
    }

    // DELETE: Reservation
    public Task<Reservation> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    // GET: Reservation details
    public Task<Reservation> Details(Guid id)
    {
        throw new NotImplementedException();
    }

    // EDIT: Reservation
    public Task<Reservation> Edit(Guid id)
    {
        throw new NotImplementedException();
    }

    
    public Task<Reservation> Edit(Reservation reservation)
    {
        throw new NotImplementedException();
    }

    // GET ALL: Reservations
    public Task<List<Reservation>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Reservation> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
