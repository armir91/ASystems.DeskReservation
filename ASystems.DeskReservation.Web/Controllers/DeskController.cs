using Microsoft.AspNetCore.Mvc;
using ASystems.DeskReservation.Web.Services.Interfaces;
using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Controllers;

public class DeskController : Controller
{
    private readonly IDeskServices _deskServices;

    public DeskController(IDeskServices deskServices)
    {
        _deskServices = deskServices;
    }

    // GET: Desks
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await _deskServices.GetAll();
        return View(result);
    }

    // GET: Desks/Details/5
    public async Task<IActionResult> Details(Guid id)
    {
        var details = await _deskServices.GetAsync(id);
        if (details == null)
        {
            return BadRequest("The user details do not exist.");
        }
        return View(details);
    }

    // GET: Desks/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Desks/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Desk desk)
    {
        await _deskServices.Create(desk);
        return RedirectToAction(nameof(Index));
    }

    // GET: Desks/Edit/5
    public async Task<IActionResult> Edit(Guid id)
    {
        var desk = await _deskServices.GetAsync(id);
        if (desk == null)
        {
            return NotFound();
        }
        return View(desk);
    }

    // POST: Desks/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Desk desk)
    {
        await _deskServices.Edit(desk);
        return RedirectToAction("Index");
    }

    // GET: Desks/Delete/5
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _deskServices.GetAsync(id);
        if (result == null)
        {
            return BadRequest("The desk does not exist.");
        }
        return View(result);
    }

    // POST: Desks/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var result = await _deskServices.Delete(id);
        if (result == null)
        {
            return BadRequest("This desk does not exist.");
        }
        return RedirectToAction("Index");
    }

    /*private bool DeskExists(Guid id)
    {
        return (_context.Desks?.Any(e => e.Id == id)).GetValueOrDefault();
    }*/
}