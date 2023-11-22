using Microsoft.AspNetCore.Mvc;
using ASystems.DeskReservation.Web.Services.Interfaces;
using ASystems.DeskReservation.Web.Data.Entities;
using Microsoft.AspNetCore.Authorization;

namespace ASystems.DeskReservation.Web.Controllers;

[Authorize]
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
        try
        {
            var result = await _deskServices.GetAll();
            return View(result);
        }
        catch (Exception)
        {

            throw new ArgumentException("No desks found.");
        }
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
        try
        {
            await _deskServices.Create(desk);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception)
        {

            throw new ArgumentException("No desk has been created.");
        }
    }

    // GET: Desks/Edit
    public async Task<IActionResult> Edit(Guid id)
    {
        var desk = await _deskServices.GetAsync(id);
        if (desk == null)
        {
            return NotFound();
        }
        return View(desk);
    }

    // POST: Desks/Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Desk desk)
    {
        try
        {
            await _deskServices.Edit(desk);
            return RedirectToAction("Index");
        }
        catch (Exception)
        {

            throw new ArgumentException("No desk details found.");
        }
    }

    // GET: Desks/Details
    public async Task<IActionResult> Details(Guid id)
    {
        var details = await _deskServices.GetAsync(id);
        if (details == null)
        {
            return BadRequest("The desk details do not exist.");
        }
        return View(details);
    }

    // GET: Desks/Delete
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _deskServices.GetAsync(id);
        if (result == null)
        {
            return BadRequest("The desk does not exist.");
        }
        return View(result);
    }

    // POST: Desks/Delete
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
}