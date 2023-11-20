﻿using Microsoft.AspNetCore.Mvc;
using ASystems.DeskReservation.Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using ASystems.DeskReservation.Web.Services.Implementations;
using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Controllers;

[Authorize(Roles = "Admin")]
public class UserController : Controller
{
    private readonly IUserServices _userServices;

    public UserController(IUserServices userServices)
    {
        _userServices = userServices;
    }

    // GET: Users
    // return a list of all users
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await _userServices.GetAll();
        return View(result);
    }

    // GET: Users/Edit
    public async Task<IActionResult> Edit(Guid id)
    {
        var result = await _userServices.GetAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return View(result);
    }

    // POST: Users/Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(User user)
    {
        await _userServices.Edit(user);
        return RedirectToAction("Index");
    }

    // GET: Users/Details/5
    public async Task<IActionResult> Details(Guid id)
    {
        var details = await _userServices.GetAsync(id);
        if (details == null)
        {
            return BadRequest("The User details could not be found.");
        }
        return View(details);
    }

    // GET: Users/Delete
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _userServices.GetAsync(id);
        if (result == null)
        {
            return BadRequest("The User does not exist.");
        }
        return View(result);
    }

    // POST: Users/Delete
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var result = await _userServices.Delete(id);
        if (result == null)
        {
            return BadRequest("This User does not exist.");
        }
        return RedirectToAction("Index");
    }
}
