﻿using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Implementations;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using ASystems.DeskReservation.Web.Services.Interfaces;

namespace ASystems.DeskReservation.Web.Services.Implementations;

public class RoleServices : IRoleServices
{
    private readonly IRoleRepository _roleRepository;

    public RoleServices(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    // GET ALL ROLES
    public async Task<List<Role>> GetAllAsync()
    {
        var result = await _roleRepository.GetAllAsync();
        return result;
    }

    public async Task<Role> GetAsync(Guid id)
    {
        var result = await _roleRepository.GetAsync(id);
        return result;
    }
    // CREATE ROLE
    public async Task<Role> Create(Role role)
    {
        var result = await _roleRepository.Create(role);
        return result;
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
