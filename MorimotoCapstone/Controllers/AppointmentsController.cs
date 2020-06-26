using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MorimotoCapstone.Data;
using MorimotoCapstone.Models;

namespace MorimotoCapstone.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentsController() : this(new ApplicationDbContext()) { }

        public AppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectListItem[] TimeZones
        {
            get
            {
                var systemTimeZones = TimeZoneInfo.GetSystemTimeZones();
                return systemTimeZones.Select(systemTimeZones => new SelectListItem
                {
                    Text = systemTimeZones.DisplayName,
                    Value = systemTimeZones.Id
                }).ToArray();
            }
        }
        // GET: AppointmentsController
        public ActionResult Index()
        {
            var appointments = _context.Appointments.ToList();
            return View(appointments);
        }

        // GET: AppointmentsController/Details/5
        public ActionResult Details(int id)
        {
            var appointmentId = _context.Appointments.Where(appt => appt.Id == id).SingleOrDefault();
            return View(appointmentId);
        }

        // GET: AppointmentsController/Create
        public ActionResult Create()
        {
            ViewBag.Timezones = TimeZones;
            var appointment = new Appointment
            {
                Timezone = "Central Standard Time",
                Time = DateTime.Now
            };
            return View(appointment);
        }

        // POST: AppointmentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,Name,PhoneNumber,Time,Timezone")]Appointment appointment)
        {
            appointment.CreatedAt = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(appointment);

                return RedirectToAction("Details", new { id = appointment.Id });
            }
            {
                return View("Create", appointment);
            }
        }

        // GET: AppointmentsController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            ViewBag.Timezones = TimeZones;
            return View(appointment);
        }

        // POST: AppointmentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppointmentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
