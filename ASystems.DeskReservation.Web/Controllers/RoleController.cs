using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASystems.DeskReservation.Web.Data.Context;
using ASystems.DeskReservation.Web.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using ASystems.DeskReservation.Web.Services.Interfaces;
using ASystems.DeskReservation.Web.Services.Implementations;
using ASystems.DeskReservation.Web.Models;

namespace ASystems.DeskReservation.Web.Controllers;

[Authorize(Roles = "Admin")]
public class RoleController : Controller
{
    private readonly IRoleServices _roleServices;

    public RoleController(IRoleServices roleServices)
    {
        _roleServices = roleServices;
    }

    // GET: Role
    public async Task<IActionResult> Index()
    {
        try
        {
			var result = await _roleServices.GetAllAsync();
			return View(result);
		}
        catch (Exception)
        {

            throw new ArgumentException("No data retrieved.");
        }
    }

    // GET: Role/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Role/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(RoleDto roleDto)
    {
        try
        {
			await _roleServices.Create(roleDto);
			return RedirectToAction("Index");
		}
        catch (Exception)
        {

            throw new ArgumentException("The role has not been created.");
        }
    }

    // GET: Role/Edit
    public async Task<IActionResult> Edit(Guid id)
    {
        var result = await _roleServices.GetAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return View(result);
    }

    // POST: Role/Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(RoleDto roleDto)
    {
        try
        {
			await _roleServices.Edit(roleDto);
			return RedirectToAction("Index");
		}
        catch (Exception)
        {

            throw new ArgumentException("The role details failed to edit.");
        }
    }

    // GET: Role/Details
    public async Task<IActionResult> Details(Guid id)
    {
        var roleDetails = await _roleServices.Details(id);
        if (roleDetails == null)
        {
            return BadRequest("The role details could not be found.");
        }
        return View(roleDetails);
    }

    // GET: Role/Delete
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _roleServices.GetAsync(id);
        if (result == null)
        {
            return BadRequest("The role does not exist.");
        }
        return View(result);
    }

    // POST: Role/Delete
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var result = await _roleServices.Delete(id);
        if (result == null)
        {
            return BadRequest("The role does not exist.");
        }
        return RedirectToAction("Index");
    }
}
