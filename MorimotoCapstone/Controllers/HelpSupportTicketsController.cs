using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MorimotoCapstone.Data;
using MorimotoCapstone.Models;

namespace MorimotoCapstone.Controllers
{
    public class HelpSupportTicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HelpSupportTicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HelpSupportTickets
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomerServiceRep = _context.CustomerServiceReps.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            if (loggedInCustomerServiceRep == null)
            {
                return RedirectToAction("Create");
            }
            var helpTicket = _context.HelpSupportTickets.ToList();
            return View(helpTicket);
        }

        // GET: HelpSupportTickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpSupportTicket = await _context.HelpSupportTickets
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (helpSupportTicket == null)
            {
                return NotFound();
            }

            return View(helpSupportTicket);
        }

        // GET: HelpSupportTickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HelpSupportTickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketId,CustomerName,CustomerComments,IsResolved")] HelpSupportTicket helpSupportTicket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(helpSupportTicket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(helpSupportTicket);
        }

        // GET: HelpSupportTickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpSupportTicket = await _context.HelpSupportTickets.FindAsync(id);
            if (helpSupportTicket == null)
            {
                return NotFound();
            }
            return View(helpSupportTicket);
        }

        // POST: HelpSupportTickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketId,CustomerName,CustomerComments,IsResolved")] HelpSupportTicket helpSupportTicket)
        {
            if (id != helpSupportTicket.TicketId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(helpSupportTicket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HelpSupportTicketExists(helpSupportTicket.TicketId))
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
            return View(helpSupportTicket);
        }

        // GET: HelpSupportTickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpSupportTicket = await _context.HelpSupportTickets
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (helpSupportTicket == null)
            {
                return NotFound();
            }

            return View(helpSupportTicket);
        }

        // POST: HelpSupportTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var helpSupportTicket = await _context.HelpSupportTickets.FindAsync(id);
            _context.HelpSupportTickets.Remove(helpSupportTicket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HelpSupportTicketExists(int id)
        {
            return _context.HelpSupportTickets.Any(e => e.TicketId == id);
        }
    }
}
