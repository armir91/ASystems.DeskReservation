using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASystems.DeskReservation.Web.Data.Context;
using ASystems.DeskReservation.Web.Data.Entities;

namespace ASystems.DeskReservation.Web.Controllers
{
    public class DeskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeskController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Desks
        public async Task<IActionResult> Index()
        {
              return _context.Desks != null ? 
                          View(await _context.Desks.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Desks'  is null.");
        }

        // GET: Desks/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Desks == null)
            {
                return NotFound();
            }

            var desk = await _context.Desks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (desk == null)
            {
                return NotFound();
            }

            return View(desk);
        }

        // GET: Desks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Desks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Desk desk)
        {
            if (ModelState.IsValid)
            {
                desk.Id = Guid.NewGuid();
                _context.Add(desk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(desk);
        }

        // GET: Desks/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Desks == null)
            {
                return NotFound();
            }

            var desk = await _context.Desks.FindAsync(id);
            if (desk == null)
            {
                return NotFound();
            }
            return View(desk);
        }

        // POST: Desks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name")] Desk desk)
        {
            if (id != desk.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(desk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeskExists(desk.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(desk);
        }

        // GET: Desks/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Desks == null)
            {
                return NotFound();
            }

            var desk = await _context.Desks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (desk == null)
            {
                return NotFound();
            }

            return View(desk);
        }

        // POST: Desks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Desks == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Desks'  is null.");
            }
            var desk = await _context.Desks.FindAsync(id);
            if (desk != null)
            {
                _context.Desks.Remove(desk);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeskExists(Guid id)
        {
          return (_context.Desks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
