using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Models;
using AutoMapper;

namespace ASystems.DeskReservation.Web.Profiler;

public class RoleProfiler : Profile
{
    public RoleProfiler()
    {
        CreateMap<RoleDto, Role>().ReverseMap().ReverseMap();
    }
}
