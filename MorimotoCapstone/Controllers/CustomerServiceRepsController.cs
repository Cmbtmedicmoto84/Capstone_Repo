using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MorimotoCapstone.ActionFilters;
using MorimotoCapstone.Data;
using MorimotoCapstone.Models;

namespace MorimotoCapstone.Controllers
{
    public class CustomerServiceRepsController : Controller
    {
        readonly ApplicationDbContext _context;

        public CustomerServiceRepsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerServiceReps
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomerServiceRep = _context.CustomerServiceReps.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            if (loggedInCustomerServiceRep == null)
            {
                return RedirectToAction("Create");
            }
            return View(loggedInCustomerServiceRep);
        }

        // GET: CustomerServiceReps/Details/5
        public ActionResult Details(int id)
        {
            var loggedInCustomerServiceRep = _context.CustomerServiceReps.Include(csr => csr.IdentityUserId).SingleOrDefault(csr => csr.CustomerServiceRepId == id);
            return View(loggedInCustomerServiceRep);
        }

        // GET: CustomerServiceReps/Create
        [HttpGet]
        public IActionResult Create()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomerServiceRep = _context.CustomerServiceReps.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            CustomerServiceRep customerServiceRep = new CustomerServiceRep();
            return View(loggedInCustomerServiceRep);
        }

        // POST: CustomerServiceReps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CustomerServiceRepId,FirstName,LastName,IdentityUserId")] CustomerServiceRep customerServiceRep)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customerServiceRep.IdentityUserId = userId;
                _context.CustomerServiceReps.Add(customerServiceRep);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
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

            return View(customerServiceRep);
        }

        // POST: CustomerServiceReps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerServiceId,FirstName,LastName,IdentityUserId")] CustomerServiceRep customerServiceRep)
        {
            if (id != customerServiceRep.CustomerServiceRepId)
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
                    if (!CustomerServiceRepExists(customerServiceRep.CustomerServiceRepId))
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
                .FirstOrDefaultAsync(m => m.CustomerServiceRepId == id);
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
            return _context.CustomerServiceReps.Any(e => e.CustomerServiceRepId == id);
        }
    }
}
