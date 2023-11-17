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

        // GET: Reservations/Details/5
        /*public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Reservations == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Desk)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }*/

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

        // GET: Reservations/Edit/5
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

        // POST: Reservations/Edit/5
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

        // GET: Reservations/Delete/5
        /*public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Reservations == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Desk)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }*/

        // POST: Reservations/Delete/5
        /* [HttpPost, ActionName("Delete")]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> DeleteConfirmed(Guid id)
         {
             if (_context.Reservations == null)
             {
                 return Problem("There are no reservations.");
             }
             var reservation = await _context.Reservations.FindAsync(id);
             if (reservation != null)
             {
                 _context.Reservations.Remove(reservation);
             }

             await _context.SaveChangesAsync();
             return RedirectToAction(nameof(Index));
         }

         private bool ReservationExists(Guid id)
         {
           return (_context.Reservations?.Any(e => e.Id == id)).GetValueOrDefault();
         }*/
    }
}
