using ASystems.DeskReservation.Web.Data.Context;
using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace ASystems.DeskReservation.Web.Repo.Implementations;

public class RoleRepository : IRoleRepository
{
    private readonly ApplicationDbContext _context;
    private readonly RoleManager<Role> _roleManager;

    public RoleRepository(ApplicationDbContext context, RoleManager<Role> roleManager)
    {
        _context = context;
        this._roleManager = roleManager;
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

    public async Task<Role> Edit(Guid id, string roleName)
    {
        try
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            role.Name = roleName;
            await _roleManager.UpdateAsync(role);

            return role;
        }
        catch (Exception)
        {

            throw new ArgumentException("No role to edit found.");
        }
    }

    // ROLE DETAILS
    public async Task<Role> Details(Guid id)
    {
        try
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            return role;
        }
        catch (Exception)
        {

            throw new ArgumentException("No role details found.");
        }
    }

    // DELETE ROLE
    public async Task<Role> Delete(Guid id)
    {
        try
        {
            var roleToDelete = await _roleManager.FindByIdAsync(id.ToString());
            await _roleManager.DeleteAsync(roleToDelete);
            await _context.SaveChangesAsync();

            return roleToDelete;
        }
        catch (Exception)
        {

            throw new ArgumentException("The role could not be deleted.");
        }
    }

}
