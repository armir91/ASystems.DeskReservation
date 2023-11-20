using ASystems.DeskReservation.Web.Data.Context;
using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Repo.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASystems.DeskReservation.Web.Repo.Implementations;

public class DeskRepository : IDeskRepository
{
    private readonly ApplicationDbContext _context;

    public DeskRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    //GET ALL
    public async Task<List<Desk>> GetAllAsync()
    {
        var result = await _context.Desks
            .OrderBy(x => x.Name)
            .ToListAsync();
        return result;
    }
    //GET BY ID
    public async Task<Desk> GetAsync(Guid id)
    {
        var result = await _context.Desks.FindAsync(id);
        if (result == null)
        {
            throw new ArgumentException("There is no desk");
        }
        return result;
    }
    // CREATE NEW
    public async Task<Desk> Create(Desk desk)
    {
        await _context.Desks.AddAsync(desk);
        await _context.SaveChangesAsync();
        return (desk);
    }
    // EDIT
    public async Task<Desk> Edit(Guid id)
    {
        var desk = await _context.Desks.FindAsync(id);
        if (desk == null)
        {
            throw new ArgumentException("There is no desk");
        }
        return desk;
    }

    public async Task<Desk> Edit(Desk desk)
    {
        if (desk == null)
        {
            throw new ArgumentException("There is no desk");
        }
        _context.Desks.Update(desk);
        await _context.SaveChangesAsync();

        return desk;
    }
    //DETAILS
    public async Task<Desk> Details(Guid id)
    {
        var result = await _context.Desks.Where((x => x.Id == id)).FirstOrDefaultAsync();
        if (result == null)
        {
            throw new ArgumentException("The desk returned no results.");
        }
        return result;
    }
    //DELETE
    public async Task<Desk> Delete(Guid id)
    {
        var result = await _context.Desks.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
        {
            throw new ArgumentException("The desk returned no results.");
        }
        _context.Desks.Remove(result);
        await _context.SaveChangesAsync();

        return result;
    }
}
