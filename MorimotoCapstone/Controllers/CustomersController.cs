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
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            if (customer == null)
            {
                return RedirectToAction("Create");
            }
            return View(customer);
        }

        // GET: Customers/Details/5
        public IActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.IdentityUserId).SingleOrDefault(c => c.CustomerAccountId == id);
            return View(customer);
        }

        [HttpGet]
        // GET: Customers/Create
        public IActionResult Create()
        {
            Customer customer = new Customer();
            return View(customer);
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("CustomerAccountId,FirstName,LastName,PhoneNumber,AddressLineOne,AddressLineTwo,City,State,ZipCode,ServiceStatus,AccountBalance,IdentityUserId,ProductId")] Customer customer)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
            
        }

        // GET: Customers/Edit/5
        public IActionResult Edit(int id)
        {
            var customersInDb = _context.Customers.Where(c => c.CustomerAccountId == id).FirstOrDefault();
            return View(customersInDb);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Customer customers)
        {
            var customersInDb = _context.Customers.Where(c => c.CustomerAccountId == id).FirstOrDefault();
            Customer customer = null;
            try
            {
                customer.PhoneNumber = Request.Form["PhoneNumber"];
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
    }
}
