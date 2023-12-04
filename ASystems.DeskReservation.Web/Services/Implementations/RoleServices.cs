using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Models;
using ASystems.DeskReservation.Web.Repo.Implementations;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using ASystems.DeskReservation.Web.Services.Interfaces;
using AutoMapper;
using NuGet.Protocol.Core.Types;

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
    public async Task<List<RoleDto>> GetAllAsync()
    {
        try
        {
            var result = await _roleRepository.GetAllAsync();
            var mappedResult = _mapper.Map<List<RoleDto>>(result);

            return mappedResult;
        }
        catch (Exception)
        {

            throw new ArgumentException("No roles retrieved.");
        }
    }

    public async Task<RoleDto> GetAsync(Guid id)
    {
        try
        {
            var result = await _roleRepository.GetAsync(id);
            var mappedResult = _mapper.Map<RoleDto>(result);

            return mappedResult;
        }
        catch (Exception)
        {

            throw new ArgumentException("No role retrieved.");
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

    public async Task<RoleDto> Edit(RoleDto roleDto)
    {
        try
        {
            var updatedRole = await _roleRepository.Edit(roleDto.Id, roleDto.Name);
            var result = _mapper.Map<RoleDto>(updatedRole);

            return result;
        }
        catch (Exception)
        {

            throw new ArgumentException("The role has not been edited.");
        }
    }

    // GET: ROLE DETAILS
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
