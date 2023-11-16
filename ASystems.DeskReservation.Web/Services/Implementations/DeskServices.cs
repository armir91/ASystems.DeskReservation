using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using ASystems.DeskReservation.Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ASystems.DeskReservation.Web.Services.Implementations;

public class DeskServices : IDeskServices
{
    private readonly IDeskRepository _deskRepository;

    public DeskServices(IDeskRepository deskRepository)
    {
        _deskRepository = deskRepository;
    }

    public async Task<List<Desk>> GetAll()
    {
        var result = await _deskRepository.GetAllAsync();
        return result;
    }

    public async Task<Desk> GetAsync(Guid id)
    {
        var desk = await _deskRepository.GetAsync(id);
        if (desk == null)
        {
            throw new ArgumentException("The desk could not be found.");
        }

        return desk;
    }
    public async Task<Desk> Create(Desk desk)
    {
        var result = await _deskRepository.Create(desk);
        return result;
    }

    public async Task<Desk> Edit(Guid id)
    {
        var desk = await _deskRepository.GetAsync(id);
        if (desk == null)
        {
            throw new ArgumentException($"The desk could not be found.");
        }

        return desk;
    }

    public async Task<Desk> Edit(Desk desk)
    {
        if (desk == null)
        {
            throw new ArgumentException("There is no desk");
        }
        return await _deskRepository.Edit(desk);
    }

    public async Task<Desk> Delete(Guid id)
    {
        var result = await _deskRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException($"The user with the ID: {id} could not be found.");
        }
        return await _deskRepository.Delete(id);
    }

    public async Task<Desk> Details(Guid id)
    {
        var result = await _deskRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException($"The desk details could not be found.");
        }
        return await _deskRepository.Details(id);
    }
}
