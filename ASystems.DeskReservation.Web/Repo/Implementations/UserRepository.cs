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

    public async Task<User> GetAsync(Guid id)
    {
        var result = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        return result;
    }

    // CREATE NEW USER
    public Task<User> Create(User user)
    {
        throw new NotImplementedException();
    }

    // EDIT USER
    public async Task<User> Edit(Guid id)
    {
        var result = await _context.Users.FindAsync(id);
        if (result == null)
        {
            throw new ArgumentException("No user found");
        }
        return result;
    }

    public async Task<User> Edit(User user)
    {
        if (user == null)
        {
            throw new ArgumentException("No user found");
        }

        user.UserName = user.Email;
        user.NormalizedUserName = user.Email.ToUpper();
        user.NormalizedEmail = user.Email.ToUpper();

         _context.Users.Update(user);
        await _context.SaveChangesAsync();

        return user;
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
