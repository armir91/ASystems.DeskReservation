using Microsoft.AspNetCore.Mvc;
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

    // GET: Users/Details/5
    /* public async Task<IActionResult> Details(Guid? id)
     {
         if (id == null || _context.Users == null)
         {
             return NotFound();
         }

         var user = await _context.Users
             .FirstOrDefaultAsync(m => m.Id == id);
         if (user == null)
         {
             return NotFound();
         }

         return View(user);
     }*/

    // GET: Users/Create
    /*public IActionResult Create()
    {
        return View();
    }*/

    // POST: Users/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    /* [HttpPost]
     [ValidateAntiForgeryToken]
     public async Task<IActionResult> Create([Bind("FirstName,LastName,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user)
     {
         if (ModelState.IsValid)
         {
             user.Id = Guid.NewGuid();
             _context.Add(user);
             await _context.SaveChangesAsync();
             return RedirectToAction(nameof(Index));
         }
         return View(user);
     }*/

    // GET: Users/Edit/5
    public async Task<IActionResult> Edit(Guid id)
    {
        var result = await _userServices.GetAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return View(result);
    }

    // POST: Users/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(User user)
    {
        await _userServices.Edit(user);
        return RedirectToAction("Index");
    }

    // GET: Users/Delete/5
    /* public async Task<IActionResult> Delete(Guid? id)
     {
         if (id == null || _context.Users == null)
         {
             return NotFound();
         }

         var user = await _context.Users
             .FirstOrDefaultAsync(m => m.Id == id);
         if (user == null)
         {
             return NotFound();
         }

         return View(user);
     }*/

    // POST: Users/Delete/5
    /* [HttpPost, ActionName("Delete")]
     [ValidateAntiForgeryToken]
     public async Task<IActionResult> DeleteConfirmed(Guid id)
     {
         if (_context.Users == null)
         {
             return Problem("Entity set 'ApplicationDbContext.Users'  is null.");
         }
         var user = await _context.Users.FindAsync(id);
         if (user != null)
         {
             _context.Users.Remove(user);
         }

         await _context.SaveChangesAsync();
         return RedirectToAction(nameof(Index));
     }*/

    /*private bool UserExists(Guid id)
    {
      return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
    }*/
}
