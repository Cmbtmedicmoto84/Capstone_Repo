using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MorimotoCapstone.Data;
using MorimotoCapstone.Models;

namespace MorimotoCapstone.Controllers
{
    public class CustomerServiceRepsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerServiceRepsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerServiceReps
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CustomerServiceReps.Include(c => c.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CustomerServiceReps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerServiceRep = await _context.CustomerServiceReps
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.CustomerServiceId == id);
            if (customerServiceRep == null)
            {
                return NotFound();
            }

            return View(customerServiceRep);
        }

        // GET: CustomerServiceReps/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: CustomerServiceReps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerServiceId,FirstName,LastName,IdentityUserId")] CustomerServiceRep customerServiceRep)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerServiceRep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customerServiceRep.IdentityUserId);
            return View(customerServiceRep);
        }

        // GET: CustomerServiceReps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerServiceRep = await _context.CustomerServiceReps.FindAsync(id);
            if (customerServiceRep == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customerServiceRep.IdentityUserId);
            return View(customerServiceRep);
        }

        // POST: CustomerServiceReps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerServiceId,FirstName,LastName,IdentityUserId")] CustomerServiceRep customerServiceRep)
        {
            if (id != customerServiceRep.CustomerServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerServiceRep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerServiceRepExists(customerServiceRep.CustomerServiceId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customerServiceRep.IdentityUserId);
            return View(customerServiceRep);
        }

        // GET: CustomerServiceReps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerServiceRep = await _context.CustomerServiceReps
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.CustomerServiceId == id);
            if (customerServiceRep == null)
            {
                return NotFound();
            }

            return View(customerServiceRep);
        }

        // POST: CustomerServiceReps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerServiceRep = await _context.CustomerServiceReps.FindAsync(id);
            _context.CustomerServiceReps.Remove(customerServiceRep);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerServiceRepExists(int id)
        {
            return _context.CustomerServiceReps.Any(e => e.CustomerServiceId == id);
        }
    }
}
