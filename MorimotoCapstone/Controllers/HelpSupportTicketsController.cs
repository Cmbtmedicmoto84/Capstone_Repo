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
    public class HelpSupportTicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HelpSupportTicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HelpSupportTickets
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.HelpSupportTickets.Include(h => h.Customer).Include(h => h.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: HelpSupportTickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpSupportTicket = await _context.HelpSupportTickets
                .Include(h => h.Customer)
                .Include(h => h.Product)
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
            ViewData["CustomerAccountId"] = new SelectList(_context.Customers, "AccountNumber", "AddressLineOne");
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId");
            return View();
        }

        // POST: HelpSupportTickets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketId,CustomerName,CustomerComments,IsResolved,CustomerAccountId,ProductId")] HelpSupportTicket helpSupportTicket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(helpSupportTicket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerAccountId"] = new SelectList(_context.Customers, "AccountNumber", "AddressLineOne", helpSupportTicket.CustomerAccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", helpSupportTicket.ProductId);
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
            ViewData["CustomerAccountId"] = new SelectList(_context.Customers, "AccountNumber", "AddressLineOne", helpSupportTicket.CustomerAccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", helpSupportTicket.ProductId);
            return View(helpSupportTicket);
        }

        // POST: HelpSupportTickets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketId,CustomerName,CustomerComments,IsResolved,CustomerAccountId,ProductId")] HelpSupportTicket helpSupportTicket)
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
            ViewData["CustomerAccountId"] = new SelectList(_context.Customers, "AccountNumber", "AddressLineOne", helpSupportTicket.CustomerAccountId);
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductId", helpSupportTicket.ProductId);
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
                .Include(h => h.Customer)
                .Include(h => h.Product)
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
