﻿using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Services.Interfaces;

public interface IRoleServices
{
    Task<List<Role>> GetAllAsync();
    Task<Role> GetAsync(Guid id);
    Task<Role> Create(Role role);
    Task<Role> Edit(Guid id);
    Task<Role> Edit(Role role);
    Task<Role> Delete(Guid id);
    Task<Role> Details(Guid id);
}
