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
    public class InstallTechesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstallTechesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InstallTeches
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.InstallTechs.Include(i => i.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: InstallTeches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var installTech = await _context.InstallTechs
                .Include(i => i.IdentityUser)
                .FirstOrDefaultAsync(m => m.TechId == id);
            if (installTech == null)
            {
                return NotFound();
            }

            return View(installTech);
        }

        // GET: InstallTeches/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: InstallTeches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TechId,FirstName,LastName,IdentityUserId")] InstallTech installTech)
        {
            if (ModelState.IsValid)
            {
                _context.Add(installTech);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", installTech.IdentityUserId);
            return View(installTech);
        }

        // GET: InstallTeches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var installTech = await _context.InstallTechs.FindAsync(id);
            if (installTech == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", installTech.IdentityUserId);
            return View(installTech);
        }

        // POST: InstallTeches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TechId,FirstName,LastName,IdentityUserId")] InstallTech installTech)
        {
            if (id != installTech.TechId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(installTech);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstallTechExists(installTech.TechId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", installTech.IdentityUserId);
            return View(installTech);
        }

        // GET: InstallTeches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var installTech = await _context.InstallTechs
                .Include(i => i.IdentityUser)
                .FirstOrDefaultAsync(m => m.TechId == id);
            if (installTech == null)
            {
                return NotFound();
            }

            return View(installTech);
        }

        // POST: InstallTeches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var installTech = await _context.InstallTechs.FindAsync(id);
            _context.InstallTechs.Remove(installTech);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstallTechExists(int id)
        {
            return _context.InstallTechs.Any(e => e.TechId == id);
        }
    }
}
