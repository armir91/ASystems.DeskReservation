using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Models;

namespace ASystems.DeskReservation.Web.Services.Interfaces;

public interface IRoleServices
{
    Task<List<RoleDto>> GetAllAsync();
    Task<RoleDto> GetAsync(Guid id);
    Task<RoleDto> Create(RoleDto roleDto);
    Task<RoleDto> Edit(RoleDto roleDto);
    Task<RoleDto> Delete(Guid id);
    Task<RoleDto> Details(Guid id);
}
