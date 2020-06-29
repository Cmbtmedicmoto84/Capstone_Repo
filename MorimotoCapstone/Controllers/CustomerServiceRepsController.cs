using System;
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
    public class CustomerServiceRepsController : Controller
    {
        private readonly ApplicationDbContext _context;

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
            var customers = _context.Customers.ToList();
            return View(customers);
        }

        // GET: CustomerServiceReps/Details/5
        public ActionResult Detail(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customers.Where(c => c.CustomerAccountId == id).FirstOrDefault();
            return View("Detail");
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

        //GET: CustomerServiceReps/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customersInDb = _context.Customers.Where(c => c.CustomerAccountId == id).FirstOrDefault();
            return View(customersInDb);
        }

        ////POST: CustomerServiceReps/Edit/5
        // //To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // //more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Customer customer)
        {
            var customersInDb = _context.Customers.Where(c => c.CustomerAccountId == id).FirstOrDefault();
            
            try
            {
                customer.FirstName = Request.Form["FirstName"];
                customer.LastName = Request.Form["LastName"];
                customer.AddressLineOne = Request.Form["AddressLineOne"];
                customer.AddressLineTwo = Request.Form["AddressLineTwo"];
                customer.City = Request.Form["City"];
                customer.State = Request.Form["State"];
                customer.ZipCode = Request.Form["ZipCode"];
                customer.ServiceStatus = Request.Form["ServiceStatus"];
                customer.AccountBalance = Request.Form["AccountBalance"];
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: CustomerServiceReps/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customerServiceRep = await _context.CustomerServiceReps
        //        .Include(c => c.IdentityUser)
        //        .FirstOrDefaultAsync(m => m.CustomerServiceRepId == id);
        //    if (customerServiceRep == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(customerServiceRep);
        //}

        //// POST: CustomerServiceReps/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var customerServiceRep = await _context.CustomerServiceReps.FindAsync(id);
        //    _context.CustomerServiceReps.Remove(customerServiceRep);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CustomerServiceRepExists(int id)
        //{
        //    return _context.CustomerServiceReps.Any(e => e.CustomerServiceRepId == id);
        //}
    }
}
