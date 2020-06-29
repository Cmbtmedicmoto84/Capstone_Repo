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
    public class InstallTechsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstallTechsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InstallTechs
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInInstallTech = _context.InstallTechs.Where(t => t.IdentityUserId == userId).SingleOrDefault();
            if (loggedInInstallTech == null)
            {
                return RedirectToAction("Create");
            }
            return View(loggedInInstallTech);
        }

        // GET: InstallTechs/Details/5
        public IActionResult Details(int id)
        {
            var loggedInInstallTech = _context.InstallTechs.Include(t => t.IdentityUserId).SingleOrDefault(t => t.InstallTechId == id);
            return View(loggedInInstallTech);
        }

        // GET: InstallTechs/Create
        [HttpGet]
        public IActionResult Create()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInInstallTech = _context.InstallTechs.Where(t => t.IdentityUserId == userId).SingleOrDefault();
            InstallTech installTech = new InstallTech();
            return View(loggedInInstallTech);
        }

        // POST: InstallTechs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("InstallTechId,FirstName,LastName,IdentityUserId")] InstallTech installTech)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                installTech.IdentityUserId = userId;
                _context.InstallTechs.Add(installTech);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(installTech);
        }

        // GET: InstallTechs/Edit/5
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

        // POST: InstallTechs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TechId,FirstName,LastName,IdentityUserId")] InstallTech installTech)
        {
            if (id != installTech.InstallTechId)
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
                    if (!InstallTechExists(installTech.InstallTechId))
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

        // GET: InstallTechs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var installTech = await _context.InstallTechs
                .Include(i => i.IdentityUser)
                .FirstOrDefaultAsync(m => m.InstallTechId == id);
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
            return _context.InstallTechs.Any(e => e.InstallTechId == id);
        }
    }
}
