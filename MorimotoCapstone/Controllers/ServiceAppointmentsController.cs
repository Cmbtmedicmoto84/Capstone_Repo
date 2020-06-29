using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MorimotoCapstone.Data;
using MorimotoCapstone.Models;

namespace MorimotoCapstone.Controllers
{
    public class ServiceAppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceAppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServiceAppointments
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInInstallTech = _context.InstallTechs.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            if (loggedInInstallTech == null)
            {
                return RedirectToAction("Create");
            }
            var appointment = _context.ServiceAppointments.ToList();
            return View(appointment);
        }

        // GET: ServiceAppointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceAppointment = await _context.ServiceAppointments
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (serviceAppointment == null)
            {
                return NotFound();
            }

            return View(serviceAppointment);
        }

        // GET: ServiceAppointments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceAppointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppointmentId,CustomerAddress,AppointmentNotes,AppointmentTime,AppointmentDate,IsComplete")] ServiceAppointment serviceAppointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceAppointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceAppointment);
        }

        // GET: ServiceAppointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceAppointment = await _context.ServiceAppointments.FindAsync(id);
            if (serviceAppointment == null)
            {
                return NotFound();
            }
            return View(serviceAppointment);
        }

        // POST: ServiceAppointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppointmentId,CustomerAddress,AppointmentNotes,AppointmentTime,AppointmentDate,IsComplete")] ServiceAppointment serviceAppointment)
        {
            if (id != serviceAppointment.AppointmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceAppointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceAppointmentExists(serviceAppointment.AppointmentId))
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
            return View(serviceAppointment);
        }

        // GET: ServiceAppointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceAppointment = await _context.ServiceAppointments
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (serviceAppointment == null)
            {
                return NotFound();
            }

            return View(serviceAppointment);
        }

        // POST: ServiceAppointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceAppointment = await _context.ServiceAppointments.FindAsync(id);
            _context.ServiceAppointments.Remove(serviceAppointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceAppointmentExists(int id)
        {
            return _context.ServiceAppointments.Any(e => e.AppointmentId == id);
        }
    }
}
