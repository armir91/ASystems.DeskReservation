using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASystems.DeskReservation.Web.Data.Context;
using ASystems.DeskReservation.Web.Data.Entities;
using ASystems.DeskReservation.Web.Services.Interfaces;

namespace ASystems.DeskReservation.Web.Controllers
{
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
            var result = await _reservationServices.GetAll();
            return View(result);
        }

        // GET: Reservations/Create Form
        public async Task<IActionResult> Create()
        {
            var usersFirstName = await _userServices.GetAll();
            ViewBag.Users = usersFirstName;

            var desks = await _deskServices.GetAll();
            ViewBag.Desks = desks;

            return View();
        }

        // POST: Reservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            var usersFirstName = await _userServices.GetAll();
            ViewBag.Users = usersFirstName;

            var desks = await _deskServices.GetAll();
            ViewBag.Desks = desks;

            await _reservationServices.Create(reservation);
            return RedirectToAction("Index");
        }

        // GET: Reservations/Edit
        public async Task<IActionResult> Edit(Guid id)
        {
            var usersFirstName = await _userServices.GetAll();
            ViewBag.Users = usersFirstName;

            var desks = await _deskServices.GetAll();
            ViewBag.Desks = desks;

            var result = await _reservationServices.GetAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        // POST: Reservations/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Reservation reservation)
        {
            var usersFirstName = await _userServices.GetAll();
            ViewBag.Users = usersFirstName;

            var desks = await _deskServices.GetAll();
            ViewBag.Desks = desks;

            await _reservationServices.Edit(reservation);
            return RedirectToAction("Index");
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
}
