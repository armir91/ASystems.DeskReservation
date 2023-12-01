using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Models;
using ASystems.DeskReservation.Web.Repo.Implementations;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using ASystems.DeskReservation.Web.Services.Interfaces;
using AutoMapper;

namespace ASystems.DeskReservation.Web.Services.Implementations;

public class RoleServices : IRoleServices
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public RoleServices(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }

    // GET ALL ROLES
    public async Task<List<Role>> GetAllAsync()
    {
        try
        {
			var result = await _roleRepository.GetAllAsync();
			return result;
		}
        catch (Exception)
        {

            throw new ArgumentException("No roles could be retrieved.");
        }
    }

    public async Task<Role> GetAsync(Guid id)
    {
        try
        {
			var result = await _roleRepository.GetAsync(id);
			return result;
		}
        catch (Exception)
        {

            throw new ArgumentException("The role could not be retrieved.");
        }
    }
    // CREATE ROLE
    public async Task<RoleDto> Create(RoleDto roleDto)
    {
        try
        {
            var newRole = new Role()
            {
                Id = roleDto.Id,
                Name = roleDto.Name
            };

            var result = await _roleRepository.Create(newRole);

            var createdRole = new RoleDto()
            {
                Id = result.Id,
                Name = result.Name
            };

            return createdRole;

        }
        catch (Exception)
        {

            throw new ArgumentException("The role has not been created.");
        }
    }

    // EDIT ROLE
    public async Task<Role> Edit(Guid id)
    {
        var result = await _roleRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException("No role found.");
        }

        return result;
    }

    public async Task<Role> Edit(Role role)
    {
        if (role == null)
        {
            throw new ArgumentException("No role found.");
        }
        return await _roleRepository.Edit(role);
    }

    // ROLE DETAILS
    public async Task<Role> Details(Guid id)
    {
        var result = await _roleRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException("No role details found.");
        }
        return await _roleRepository.Details(id);
    }

    // DELETE ROLE
    public async Task<Role> Delete(Guid id)
    {
        var result = await _roleRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException($"The role with the ID: {id} could not be found.");
        }
        return await _roleRepository.Delete(id);
    }
}
