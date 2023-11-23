using Microsoft.AspNetCore.Mvc;
using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ASystems.DeskReservation.Web.Controllers;

[Authorize]
public class ReservationController : Controller
{
    private readonly IReservationServices _reservationServices;
    private readonly IDeskServices _deskServices;
    private readonly IUserServices _userServices;

    public ReservationController(IReservationServices reservationServices, IDeskServices deskServices, IUserServices userServices)
    {
        _reservationServices = reservationServices;
        _deskServices = deskServices;
        _userServices = userServices;
    }

    // GET: Reservations
    public async Task<IActionResult> Index()
    {
        try
        {
            var currentLoggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _reservationServices.GetAll();

            if (User.IsInRole("Admin"))
            {
                return View(result);
            }
            var loggedInUserData = result.Where(x => x.UserId.ToString() == currentLoggedInUserId).ToList();

            return View(loggedInUserData);
        }
        catch (Exception)
        {

            throw new ArgumentException("No data retrieved");
        }
    }

    // GET: Reservations/Create Form
    public async Task<IActionResult> Create([FromQuery]DateTime? StartDate, [FromQuery]DateTime? EndDate)
    {
        try
        {
            var currentLoggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usersFirstName = await _userServices.GetAll();

            if (User.IsInRole("Admin"))
            {
                ViewBag.Users = usersFirstName;
            }
            else
            {
                ViewBag.Users = usersFirstName.Where(x => x.Id.ToString() == currentLoggedInUserId);
            }

            var startDate = StartDate.HasValue ? StartDate.Value : DateTime.Now;
            var endDate = EndDate.HasValue ? EndDate.Value : startDate.AddDays(5);


            var desks = await _deskServices.GetFreeDesks(startDate, endDate);
            ViewBag.Desks = desks;

            var model = new Reservation()
            {
                StartDate = startDate,
                EndDate = endDate
            };

            return View(model);
        }
        catch (Exception)
        {

            throw new ArgumentException("The reservation did not create.");
        }
    }

    // POST: Reservations/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Reservation reservation)
    {
        try
        {
            var currentLoggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var existingReservations = await _reservationServices.GetUserReservations(Guid.Parse(currentLoggedInUserId), reservation.StartDate, reservation.EndDate);

            if (existingReservations.Count > 0)
            {
                ModelState.AddModelError(string.Empty, "User has already a reservation for the searched days.");
                /*return RedirectToAction("Create", new {StartDate = reservation.StartDate, EndDate = reservation.EndDate});*/

                var usersFirstName = await _userServices.GetAll();

                if (User.IsInRole("Admin"))
                {
                    ViewBag.Users = usersFirstName;
                }
                else
                {
                    ViewBag.Users = usersFirstName.Where(x => x.Id.ToString() == currentLoggedInUserId);
                }

                var desks = await _deskServices.GetFreeDesks(reservation.StartDate, reservation.EndDate);
                ViewBag.Desks = desks;

                return View(reservation);
            }

            reservation.UserId = Guid.Parse(currentLoggedInUserId);
            reservation.ReservedTime = DateTime.Now;
            reservation.Status = ReservationStatus.Pending;

            var createdReservation = await _reservationServices.Create(reservation);
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Edit", new { id = createdReservation.Id });
            }
            return RedirectToAction("Index");
        }
        catch (Exception)
        {

            throw new ArgumentException("The reservation could not be saved in the DataBase.");
        }
    }

    // GET: Reservations/Edit
    public async Task<IActionResult> Edit(Guid id)
    {
        try
        {
            var currentLoggedInUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var usersFirstName = await _userServices.GetAll();

            if (User.IsInRole("Admin"))
            {
                ViewBag.Users = usersFirstName;
            }
            else
            {
                ViewBag.Users = usersFirstName.Where(x => x.Id.ToString() == currentLoggedInUserId);
            }

            var desks = await _deskServices.GetAll();
            ViewBag.Desks = desks;

            var result = await _reservationServices.GetAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }
        catch (Exception)
        {

            throw new ArgumentException("Could not get the reservation details for modification.");
        }
    }

    // POST: Reservations/Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Reservation reservation)
    {
        try
        {
            var usersFirstName = await _userServices.GetAll();
            ViewBag.Users = usersFirstName;

            var desks = await _deskServices.GetAll();
            ViewBag.Desks = desks;

            await _reservationServices.Edit(reservation);
            return RedirectToAction("Index");
        }
        catch (Exception)
        {

            throw new ArgumentException("No reservation could noy be modified.");
        }
    }

    // GET: Reservation/Details
    public async Task<IActionResult> Details(Guid id)
    {
        var details = await _reservationServices.GetAsync(id);
        if (details == null)
        {
            return BadRequest("The reservation details could not be found.");
        }
        return View(details);
    }

    // GET: Reservations/Delete
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _reservationServices.GetAsync(id);
        if (result == null)
        {
            return BadRequest("The reservation does not exist.");
        }
        return View(result);
    }

    // POST: Reservations/Delete
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var result = await _reservationServices.Delete(id);
        if (result == null)
        {
            return BadRequest("This reservation does not exist.");
        }
        return RedirectToAction("Index");
    }
}
