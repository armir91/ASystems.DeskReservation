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
        return await _context.Users
            .OrderBy(x => x.FirstName)
            .ToListAsync();
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
    public async Task<User> Details(Guid id)
    {
        var result = await _context.Users.Where((x => x.Id == id)).FirstOrDefaultAsync();
        if (result == null)
        {
            throw new ArgumentException("No User found.");
        }
        return result;
    }

    // DELETE A USER
    public async Task<User> Delete(Guid id)
    {
        var result = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
        {
            throw new ArgumentException("No User found.");
        }
        _context.Users.Remove(result);
        await _context.SaveChangesAsync();

        return result;
    }
}
