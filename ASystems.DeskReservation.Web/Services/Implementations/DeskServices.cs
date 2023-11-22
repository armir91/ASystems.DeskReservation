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

    // GET ALL DESKS
    public async Task<List<Desk>> GetAll()
    {
        try
        {
            var result = await _deskRepository
            .GetAllAsync();
            return result;
        }
        catch (Exception)
        {

            throw new ArgumentException("No desks retrieved.");
        }
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

    // CREATE A NEW DESK
    public async Task<Desk> Create(Desk desk)
    {
        try
        {
            var result = await _deskRepository.Create(desk);
            return result;
        }
        catch (Exception)
        {

            throw new ArgumentException("No desk could be created");
        }
    }

    // EDIT DESK

    public async Task<Desk> Edit(Guid id)
    {
        var desk = await _deskRepository.GetAsync(id);
        if (desk == null)
        {
            throw new ArgumentException("The desk could not be found.");
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

    // DESK DETAILS
    public async Task<Desk> Details(Guid id)
    {
        var result = await _deskRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException("The desk details could not be found.");
        }
        return await _deskRepository.Details(id);
    }

    // DELETE DESK
    public async Task<Desk> Delete(Guid id)
    {
        var result = await _deskRepository.GetAsync(id);
        if (result == null)
        {
            throw new ArgumentException($"The user with the ID: {id} could not be found.");
        }
        return await _deskRepository.Delete(id);
    }

    public async Task<List<Desk>> GetFreeDesks(DateTime StartDate, DateTime EndDate)
    {
        try
        {
            var result = await _deskRepository.GetFreeDesks(StartDate, EndDate);

            return result;
        }
        catch (Exception)
        {

            throw new ArgumentException("No free desks found.");
        }
    }
}
