using Microsoft.AspNetCore.Mvc;
using ASystems.DeskReservation.Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using ASystems.DeskReservation.Web.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASystems.DeskReservation.Web.Models;

namespace ASystems.DeskReservation.Web.Controllers;

[Authorize(Roles = "Admin")]
public class UserController : Controller
{
    private readonly IUserServices _userServices;
    private readonly UserManager<User> _userManager;
    private readonly IRoleServices _roleServices;

    public UserController(IUserServices userServices, UserManager<User> userManager, IRoleServices roleServices)
    {
        _userServices = userServices;
        _userManager = userManager;
        _roleServices = roleServices;
    }

    // GET: Users
    // return a list of all users
    [HttpGet]
    public async Task<IActionResult> Index()
    {

        var users = await _userServices.GetAll();
        /*var userRoles = new List<string>();
        foreach (var item in users)
        {
           userRoles = (List<string>)await _userManager.GetRolesAsync(item);
        }*/
        return View(users);
    }

    // GET: Users/Edit
    public async Task<IActionResult> Edit(Guid id)
    {
        var result = await _userServices.GetAsync(id);

        var roles = await _roleServices.GetAllAsync();

        var userRoles = await _userManager.GetRolesAsync(result);

        var userRoleName = userRoles.FirstOrDefault();

        var roleItems = roles.Select(role =>
        new SelectListItem
            (role.Name, role.Name,
            userRoles.Any(u => u.Contains(role.Name)
            ))).ToList();

        ViewBag.Roles = roleItems;

        if (result == null)
        {
            return NotFound();
        }

        var userDto = new UserDto()
        {
            Id = id,
            FirstName = result.FirstName,
            LastName = result.LastName,
            Email = result.Email,
            PhoneNumber = result.PhoneNumber,
            RoleName = userRoleName
        };

        return View(userDto);
    }

    // POST: Users/Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UserDto userDto)
    {

        await _userServices.Edit(userDto);
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
