﻿using System;
using System.Collections;
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
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomer = _context.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            if(loggedInCustomer == null)
            {
                return RedirectToAction("Create");
            }
            return View(loggedInCustomer);
        }

        // GET: Customers/Details/5
        public IActionResult Details()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomer = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            if (loggedInCustomer == null)
            {
                return RedirectToAction("Details");
            }
            return View(loggedInCustomer);
        }

        // GET: Customers/Create
        [HttpGet]
        public IActionResult Create()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInCustomer = _context.Customers.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            return View(loggedInCustomer);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CustomerAccountId,FirstName,LastName,AddressLineOne,AddressLineTwo,City,State,ZipCode")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        //[Authorize(Roles = "CustomerServiceRep")]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customersInDb = _context.Customers.Where(c => c.CustomerAccountId == id).SingleOrDefault();
            return View(customersInDb);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "CustomerServiceRep")]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerAccountId,FirstName,LastName,AddressLineOne,AddressLineTwo,City,State,ZipCode,ServiceStatus,AccountBalance,IdentityUserId,ProductId")] Customer customer)
        {
            if (id != customer.CustomerAccountId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerAccountId))
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        [Authorize(Roles = "CustomerServiceRep")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.CustomerAccountId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "CustomerServiceRep")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerAccountId == id);
        }
    }
}
