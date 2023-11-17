using ASystems.DeskReservation.Web.Data.Context;
using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ASystems.DeskReservation.Web.Repo.Implementations;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET ALL USERS
    public async Task<List<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public Task<User> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    // CREATE NEW USER
    public Task<User> Create(User user)
    {
        throw new NotImplementedException();
    }

    // EDIT USER
    public Task<User> Edit(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> Edit(User user)
    {
        throw new NotImplementedException();
    }

    // USER DETAILS
    public Task<User> Details(Guid id)
    {
        throw new NotImplementedException();
    }

    // DELETE A USER
    public Task<User> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
