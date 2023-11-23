using ASystems.DeskReservation.Web.Data.Context;
using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace ASystems.DeskReservation.Web.Repo.Implementations;

public class RoleRepository : IRoleRepository
{
    private readonly ApplicationDbContext _context;

    public RoleRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    //GET ALL ROLES
    public async Task<List<Role>> GetAllAsync()
    {
        try
        {
			var result = await _context.Roles
			.OrderBy(x => x.Name)
			.ToListAsync();

			return result;
		}
        catch (Exception)
        {

            throw new ArgumentException("No data could be retrieved.");
        }
    }

    public async Task<Role> GetAsync(Guid id)
    {
        try
        {
			var result = await _context.Roles.FirstOrDefaultAsync(m => m.Id == id);
			return result;
		}
        catch (Exception)
        {

            throw new ArgumentException($"The role with ID: {id} could no be retrieved");
        }
    }

    //CREATE NEW ROLE
    public async Task<Role> Create(Role role)
    {
        try
        {
			role.NormalizedName = role.Name.ToUpper();

			await _context.Roles.AddAsync(role);
			await _context.SaveChangesAsync();
			return role;
		}
        catch (Exception)
        {
            throw new ArgumentException("The role could not be created.");
        }
    }

    // EDIT ROLE
    public async Task<Role> Edit(Guid id)
    {
		var result = await _context.Roles.FindAsync(id);
		if (result == null)
		{
			throw new ArgumentException("No role found");
		}
		return result;
	}

    public async Task<Role> Edit(Role role)
    {
        if (role == null)
        {
            throw new ArgumentException("No role found");
        }
        _context.Roles.Update(role);
        await _context.SaveChangesAsync();

        return role;
    }

    // ROLE DETAILS
    public async Task<Role> Details(Guid id)
    {
        var result = await _context.Roles.Where((x => x.Id == id)).FirstOrDefaultAsync();
        if (result == null)
        {
            throw new ArgumentException("No Role found.");
        }
        return result;
    }

    // DELETE ROLE
    public async Task<Role> Delete(Guid id)
    {
        var result = await _context.Roles.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
        {
            throw new ArgumentException("No role found.");
        }
        _context.Roles.Remove(result);
        await _context.SaveChangesAsync();

        return result;
    }

}
